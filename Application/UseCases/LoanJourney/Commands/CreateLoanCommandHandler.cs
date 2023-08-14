using Application.Persistance;
using Application.Persistance.Common;
using Application.UseCases.LoanJourney.Results;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.LoanJourney.Commands {

    public class CreateLoanCommand : IRequest<LoanResult> {
        public Guid ApplicationId { get; set; }
        public Guid LenderId { get; set; }
    }

    public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, LoanResult> {

        private readonly IApplicationRepository _applicationRepository;
        private readonly ILenderRepository _lenderRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<LocalizationResources> _localization;
        private readonly ILenderMatrixRepository _lenderMatrixRepository;
        private readonly ILoanRepository _loanRepository;

        public CreateLoanCommandHandler(IStringLocalizer<LocalizationResources> localization,
                                        IMapper mapper,
                                        IUnitOfWork unitOfWork,
                                        ILenderRepository lenderRepository,
                                        IApplicationRepository applicationRepository,
                                        ILenderMatrixRepository lenderMatrixRepository,
                                        ILoanRepository loanRepository) {
            _localization = localization;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _lenderRepository = lenderRepository;
            _applicationRepository = applicationRepository;
            _lenderMatrixRepository = lenderMatrixRepository;
            _loanRepository = loanRepository;
        }

        public async Task<LoanResult> Handle(CreateLoanCommand request, CancellationToken cancellationToken) {

            if (await _applicationRepository.ContainsAsync(request.ApplicationId) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("").Value);

            if (await _lenderRepository.ContainsAsync(request.LenderId) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("").Value);

            var application = await _applicationRepository.GetWithProductAsync(request.ApplicationId);

            if (await _applicationRepository.IsApprovedAsLoanAsync(application.Id) is true)
                throw new Exception("this application already is a loan");

            var lender = await _lenderRepository.GetByIdAsync(request.LenderId);

            if (await IsEligible(lender, application) is false)
                throw new NoSuchEntityExistsException("Lender not eligible");

            var product = application.Product;

            if (await _lenderMatrixRepository.ContainsAsync(request.LenderId, product.Id, application.RequestedTenor) is false)
                throw new NoSuchEntityExistsException(_localization.GetString("").Value);

            var matrix = await _lenderMatrixRepository.GetByIdAsync(request.LenderId, product.Id, application.RequestedTenor);

            var loan = new Loan {
                Id = Guid.NewGuid(),
                RequestedAmount = application.RequestedAmount,
                ReferenceRate = product.ReferenceRate,
                InterestRate = matrix.Spread + product.ReferenceRate,
                Tenor = application.RequestedTenor,
                ProductId = product.Id,
                Status = application.Status
            };

            loan.Application = application;
            loan.Lender = lender;

            await _loanRepository.CreateAsync(loan);

            await _unitOfWork.SaveChangesAsync();

            return new LoanResult {
                Id = loan.Id,
                InterestRate = loan.InterestRate,
                ReferenceRate = loan.ReferenceRate,
                RequestedAmount = loan.RequestedAmount,
                Status = loan.Status,
                Tenor = loan.Tenor
            };
        }

        private async Task<bool> IsEligible(Lender lender, ApplicationEntity application) {

            if (lender.MinTenor > application.RequestedTenor && lender.MaxTenor < application.RequestedTenor)
                return false;

            if (lender.RequestedAmount > application.RequestedAmount)
                return false;

            if (lender.BorrowerCompanyType != await _applicationRepository.GetCompanyTypeAsync(application.Id))
                return false;

            return true;
        }

    }

    public class CreateLoanCommandValidator : AbstractValidator<CreateLoanCommand> {
        public CreateLoanCommandValidator() {
            RuleFor(x => x.ApplicationId)
                .NotEmpty().WithMessage("EmptyId");

            RuleFor(x => x.LenderId)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}