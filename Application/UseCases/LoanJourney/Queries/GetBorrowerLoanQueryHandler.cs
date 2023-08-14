using Application.Persistance;
using Application.UseCases.LoanJourney.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.LoanJourney.Queries {

    public class GetBorrowerLoanQuery : IRequest<LoanResult> {
        public Guid BorrowerId { get; set; }
        public Guid LoanId { get; set; }
    }


    public class GetBorrowerLoanQueryHandler : IRequestHandler<GetBorrowerLoanQuery, LoanResult> {

        private readonly ILoanRepository _loanRepository;
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IMapper _mapper;

        public GetBorrowerLoanQueryHandler(IMapper mapper, IBorrowerRepository borrowerRepository, ILoanRepository loanRepository) {
            _mapper = mapper;
            _borrowerRepository = borrowerRepository;
            _loanRepository = loanRepository;
        }

        public async Task<LoanResult> Handle(GetBorrowerLoanQuery request, CancellationToken cancellationToken) {

            if (await _borrowerRepository.ContainsAsync(request.BorrowerId) is false)
                throw new NoSuchEntityExistsException("");

            if (await _loanRepository.ContainsAsync(request.LoanId) is false)
                throw new NoSuchEntityExistsException("");

            var loan = await _loanRepository.GetLoanByBorrowerAsync(request.BorrowerId, request.LoanId)
                       ?? throw new Exception("loan doesnt belong to borrower");

            return _mapper.Map<LoanResult>(loan);
        }
    }

    public class GetBorrowerLoanQueryValidator : AbstractValidator<GetBorrowerLoanQuery> {
        public GetBorrowerLoanQueryValidator() {
            RuleFor(x => x.BorrowerId)
                .NotEmpty().WithMessage("EmptyId");

            RuleFor(x => x.LoanId)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
