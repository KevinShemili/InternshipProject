using Application.Exceptions;
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

    public class CreateApplicationCommand : IRequest<ApplicationCommandResult> {
        public Guid BorrowerId { get; set; }
        public int RequestedAmount { get; set; }
        public int RequestedTenor { get; set; }
        public string FinancePurposeDefinition { get; set; } = null!;
    }

    public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, ApplicationCommandResult> {

        private readonly IApplicationRepository _applicationRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IApplicationStatusRepository _applicationStatusRepository;

        public CreateApplicationCommandHandler(IStringLocalizer<LocalizationResources> localizer,
            IApplicationRepository applicationRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IProductRepository productRepository,
            IBorrowerRepository borrowerRepository,
            IApplicationStatusRepository applicationStatusRepository) {
            _localizer = localizer;
            _applicationRepository = applicationRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _productRepository = productRepository;
            _borrowerRepository = borrowerRepository;
            _applicationStatusRepository = applicationStatusRepository;
        }

        public async Task<ApplicationCommandResult> Handle(CreateApplicationCommand request, CancellationToken cancellationToken) {

            var product = await _productRepository.GetByNameAsync(ProductSeeds.FixedRatePreAmortization);

            if (product.FinanceMaxAmount < request.RequestedAmount)
                throw new InvalidInputException(_localizer.GetString("BiggerRequestAmount").Value);
            else if (product.FinanceMinAmount > request.RequestedAmount)
                throw new InvalidInputException(_localizer.GetString("SmallerRequestAmount").Value);

            if (await _borrowerRepository.ContainsAsync(request.BorrowerId) is false)
                throw new ForbiddenException(_localizer.GetString("BorrowerDoesntExist").Value);

            var application = _mapper.Map<ApplicationEntity>(request);
            application.Id = Guid.NewGuid();
            application.BorrowerId = request.BorrowerId;
            application.Name = request.RequestedAmount.ToString() + " - " + DateTime.UtcNow.ToString("d");
            application.ApplicationStatus = await _applicationStatusRepository.GetByIdAsync(DefinedApplicationStatuses.InCharge.Id);
            application.Product = product;

            await _applicationRepository.CreateAsync(application);
            await _unitOfWork.SaveChangesAsync();

            return new ApplicationCommandResult {
                Id = application.Id,
                Name = application.Name,
                Description = application.FinancePurposeDefinition
            };
        }
    }

    public class CreateApplicationCommandValidator : AbstractValidator<CreateApplicationCommand> {
        public CreateApplicationCommandValidator() {
            RuleFor(x => x.BorrowerId)
                .NotEmpty().WithMessage("EmptyId");

            RuleFor(x => x.RequestedAmount)
                .NotEmpty().WithMessage("EmptyRequestAmount");

            RuleFor(x => x.RequestedTenor)
                .NotEmpty().WithMessage("EmptyRequestTenor");

            RuleFor(x => x.FinancePurposeDefinition)
                .NotEmpty().WithMessage("EmptyFinancePurposeDefinition.")
                .MaximumLength(100).WithMessage("FinancePurposeMaximumLengthRestriction");
        }
    }
}
