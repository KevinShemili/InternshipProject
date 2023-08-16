using Application.Exceptions;
using Application.Persistance;
using Application.UseCases.LoanJourney.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.LoanJourney.Queries {

    public class GetBorrowerLoanQuery : IRequest<LoanResult> {
        public Guid BorrowerId { get; set; }
        public Guid LoanId { get; set; }
    }


    public class GetBorrowerLoanQueryHandler : IRequestHandler<GetBorrowerLoanQuery, LoanResult> {

        private readonly ILoanRepository _loanRepository;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<LocalizationResources> _localization;

        public GetBorrowerLoanQueryHandler(IMapper mapper,
                                           IBorrowerRepository borrowerRepository,
                                           ILoanRepository loanRepository,
                                           IStringLocalizer<LocalizationResources> localization) {
            _mapper = mapper;
            _borrowerRepository = borrowerRepository;
            _loanRepository = loanRepository;
            _localization = localization;
        }

        public async Task<LoanResult> Handle(GetBorrowerLoanQuery request, CancellationToken cancellationToken) {

            if (await _borrowerRepository.ContainsAsync(request.BorrowerId) is false)
                throw new NoSuchEntityExistsException("");

            if (await _loanRepository.ContainsAsync(request.LoanId) is false)
                throw new NoSuchEntityExistsException("");

            var loan = await _loanRepository.GetLoanByBorrowerAsync(request.BorrowerId, request.LoanId)
                       ?? throw new InvalidInputException(_localization.GetString("DoesntBelongTo").Value);

            return _mapper.Map<LoanResult>(loan);
        }
    }

    public class GetBorrowerLoanQueryValidator : AbstractValidator<GetBorrowerLoanQuery> {
        public GetBorrowerLoanQueryValidator() {
            RuleFor(x => x.BorrowerId)
                .NotEmpty().WithMessage("EmptyBorrowerId");

            RuleFor(x => x.LoanId)
                .NotEmpty().WithMessage("EmptyLoanId");
        }
    }
}
