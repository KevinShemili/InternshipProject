using Application.Persistance;
using Application.Persistance.Common;
using Domain.Exceptions;
using Domain.Seeds;
using FluentValidation;
using MediatR;

namespace Application.UseCases.LoanJourney.Commands {

    public class ChangeLoanStatusCommand : IRequest<bool> {
        public Guid LoanId { get; set; }
        public Guid StatusId { get; set; }
    }


    public class ChangeLoanStatusCommandHandler : IRequestHandler<ChangeLoanStatusCommand, bool> {

        private readonly ILoanStatusRepository _loanStatusRepository;
        private readonly ILoanRepository _loanRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IApplicationRepository _applicationRepository;

        public ChangeLoanStatusCommandHandler(IUnitOfWork unitOfWork,
                                              ILoanRepository loanRepository,
                                              ILoanStatusRepository loanStatusRepository,
                                              IApplicationRepository applicationRepository) {
            _unitOfWork = unitOfWork;
            _loanRepository = loanRepository;
            _loanStatusRepository = loanStatusRepository;
            _applicationRepository = applicationRepository;
        }

        public async Task<bool> Handle(ChangeLoanStatusCommand request, CancellationToken cancellationToken) {

            if (await _loanRepository.ContainsAsync(request.LoanId) is false)
                throw new NoSuchEntityExistsException("");

            if (await _loanStatusRepository.ContainsAsync(request.StatusId) is false)
                throw new NoSuchEntityExistsException("");

            var loan = await _loanRepository.GetByIdWithApplication(request.LoanId);
            var application = loan.Application;
            var status = await _loanStatusRepository.GetByIdAsync(request.StatusId);

            switch (status.Name) {
                case DefinedLoanStatuses.Created.Name:
                    await _applicationRepository.UpdateStatus(application.Id, DefinedApplicationStatuses.InCharge.Id);
                    await _loanRepository.UpdateStatus(loan.Id, DefinedLoanStatuses.Created.Id);
                    break;
                case DefinedLoanStatuses.Erased.Name:
                    await _applicationRepository.UpdateStatus(application.Id, DefinedApplicationStatuses.Canceled.Id);
                    await _loanRepository.UpdateStatus(loan.Id, DefinedLoanStatuses.Erased.Id);
                    break;
                case DefinedLoanStatuses.Defaulted.Name:
                    await _applicationRepository.UpdateStatus(application.Id, DefinedApplicationStatuses.Defaulted.Id);
                    await _loanRepository.UpdateStatus(loan.Id, DefinedLoanStatuses.Defaulted.Id);
                    break;
                case DefinedLoanStatuses.Disbursed.Name:
                    await _applicationRepository.UpdateStatus(application.Id, DefinedApplicationStatuses.Disbursed.Id);
                    await _loanRepository.UpdateStatus(loan.Id, DefinedLoanStatuses.Disbursed.Id);
                    break;
                case DefinedLoanStatuses.Guaranted.Name:
                    await _applicationRepository.UpdateStatus(application.Id, DefinedApplicationStatuses.Guaranted.Id);
                    await _loanRepository.UpdateStatus(loan.Id, DefinedLoanStatuses.Guaranted.Id);
                    break;
                case DefinedLoanStatuses.Rejected.Name:
                    await _applicationRepository.UpdateStatus(application.Id, DefinedApplicationStatuses.Rejected.Id);
                    await _loanRepository.UpdateStatus(loan.Id, DefinedLoanStatuses.Rejected.Id);
                    break;
                case DefinedLoanStatuses.Repaid.Name:
                    await _applicationRepository.UpdateStatus(application.Id, DefinedApplicationStatuses.Repaid.Id);
                    await _loanRepository.UpdateStatus(loan.Id, DefinedLoanStatuses.Repaid.Id);
                    break;
                default:
                    throw new Exception();
            }

            var flag = await _unitOfWork.SaveChangesAsync();

            if (flag is false)
                throw new Exception();

            return true;
        }
    }

    public class ChangeLoanStatusCommandValidator : AbstractValidator<ChangeLoanStatusCommand> {
        public ChangeLoanStatusCommandValidator() {
            RuleFor(x => x.StatusId)
                .NotEmpty().WithMessage("EmptyId");

            RuleFor(x => x.LoanId)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
