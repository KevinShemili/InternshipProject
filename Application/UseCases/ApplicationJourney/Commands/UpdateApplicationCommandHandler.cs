using Application.Exceptions;
using Application.Exceptions.ServerErrors;
using Application.Persistance;
using Application.Persistance.Common;
using Application.UseCases.ApplicationJourney.Results;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Seeds;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.ApplicationJourney.Commands {

    public class UpdateApplicationCommand : IRequest<ApplicationCommandResult> {
        public Guid Id { get; set; }
        public int RequestedAmount { get; set; }
        public int RequestedTenor { get; set; }
        public string FinancePurposeDefinition { get; set; } = null!;
        public string ProductId { get; set; } = null!;
    }

    public class UpdateApplicationCommandHandler : IRequestHandler<UpdateApplicationCommand, ApplicationCommandResult> {

        private readonly IApplicationRepository _applicationRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public UpdateApplicationCommandHandler(IStringLocalizer<LocalizationResources> localizer,
                                               IApplicationRepository applicationRepository,
                                               IProductRepository productRepository,
                                               IMapper mapper,
                                               IUnitOfWork unitOfWork) {
            _localizer = localizer;
            _applicationRepository = applicationRepository;
            _productRepository = productRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<ApplicationCommandResult> Handle(UpdateApplicationCommand request, CancellationToken cancellationToken) {

            if (await _applicationRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("ApplicationDoesntExist").Value);

            var application = await _applicationRepository.GetByIdAsync(request.Id);

            var productId = Guid.Parse(request.ProductId);

            if (await _productRepository.ContainsAsync(productId) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("ProductTypeDoesntExist").Value);

            var product = await _productRepository.GetByIdAsync(productId);

            if (product.FinanceMaxAmount < request.RequestedAmount)
                throw new InvalidInputException(_localizer.GetString("BiggerRequestAmount").Value);
            else if (product.FinanceMinAmount > request.RequestedAmount)
                throw new InvalidInputException(_localizer.GetString("SmallerRequestAmount").Value);

            var newApplication = _mapper.Map<ApplicationEntity>(request);
            newApplication.Id = application.Id;
            newApplication.Product = product;
            newApplication.Name = GenerateName(application.Name, request.RequestedAmount);

            await _applicationRepository.UpdateAsync(newApplication);

            var flag = await _unitOfWork.SaveChangesAsync();

            if (flag is false)
                throw new DatabaseException(_localizer.GetString("DatabaseException").Value);

            return _mapper.Map<ApplicationCommandResult>(application);
        }

        private static string GenerateName(string name, int amount) {
            var parts = name.Split(" - ");
            parts[0] = amount.ToString();
            return string.Join(" - ", parts);
        }
    }

    public class UpdateApplicationCommandValidator : AbstractValidator<UpdateApplicationCommand> {
        public UpdateApplicationCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");

            RuleFor(x => x.RequestedAmount)
                .NotEmpty().WithMessage("EmptyRequestAmount");

            RuleFor(x => x.RequestedTenor)
                .NotEmpty().WithMessage("EmptyRequestTenor");

            RuleFor(x => x.RequestedTenor <= DefinedTenors.MaximumTenor && x.RequestedTenor >= DefinedTenors.MinimumTenor)
                .NotEmpty().WithMessage("TenorConstraint");

            RuleFor(x => x.ProductId)
                .NotEmpty().WithMessage("EmptyId");

            RuleFor(x => x.FinancePurposeDefinition)
                .NotEmpty().WithMessage("EmptyFinancePurposeDefinition")
                .MaximumLength(100).WithMessage("FinancePurposeMaximumLengthRestriction");
        }
    }
}
