using Application.Exceptions;
using Application.Persistance;
using Application.Persistance.Common;
using Application.UseCases.ApplicationJourney.Results;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
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
        public string ProductType { get; set; } = null!;
    }

    public class UpdateApplicationCommandHandler : IRequestHandler<UpdateApplicationCommand, ApplicationCommandResult> {

        private readonly IApplicationRepository _applicationRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public UpdateApplicationCommandHandler(IStringLocalizer<LocalizationResources> localizer, IApplicationRepository applicationRepository, IProductRepository productRepository, IMapper mapper, IUnitOfWork unitOfWork) {
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

            if (await _productRepository.ContainsAsync(request.ProductType) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("ProductTypeDoesntExist").Value);

            var product = await _productRepository.GetByNameAsync(request.ProductType);

            if (product.FinanceMaxAmount < request.RequestedAmount)
                throw new InvalidInputException(_localizer.GetString("BiggerRequestAmount").Value);
            else if (product.FinanceMinAmount > request.RequestedAmount)
                throw new InvalidInputException(_localizer.GetString("SmallerRequestAmount").Value);

            var newApplication = _mapper.Map<ApplicationEntity>(request);
            newApplication.Product = product;
            var parts = application.Name.Split(" - ");
            parts[0] = request.RequestedAmount.ToString();
            newApplication.Name = string.Join(" - ", parts);

            await _applicationRepository.UpdateAsync(request.Id, newApplication);
            await _unitOfWork.SaveChangesAsync();

            return new ApplicationCommandResult {
                Id = application.Id,
                Name = newApplication.Name,
                Description = request.FinancePurposeDefinition
            };
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

            RuleFor(x => x.ProductType)
                .NotEmpty().WithMessage("EmptyProductType");

            RuleFor(x => x.FinancePurposeDefinition)
                .NotEmpty().WithMessage("EmptyFinancePurposeDefinition.")
                .MaximumLength(100).WithMessage("FinancePurposeMaximumLengthRestriction");
        }
    }
}
