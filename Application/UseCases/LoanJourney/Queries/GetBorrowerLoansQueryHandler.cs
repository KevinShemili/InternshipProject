using Application.Persistance;
using Application.UseCases.LoanJourney.Results;
using AutoMapper;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.LoanJourney.Queries {

    public class GetBorrowerLoansQuery : IRequest<IEnumerable<LoanResult>> {
        public Guid BorrowerId { get; set; }
    }

    public class GetBorrowerLoansQueryHandler : IRequestHandler<GetBorrowerLoansQuery, IEnumerable<LoanResult>> {

        private readonly IBorrowerRepository _borrowerRepository;
        private readonly ILoanRepository _loanRepository;
        private readonly IMapper _mapper;

        public GetBorrowerLoansQueryHandler(ILoanRepository loanRepository, IBorrowerRepository borrowerRepository, IMapper mapper) {
            _loanRepository = loanRepository;
            _borrowerRepository = borrowerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LoanResult>> Handle(GetBorrowerLoansQuery request, CancellationToken cancellationToken) {

            if (await _borrowerRepository.ContainsAsync(request.BorrowerId) is false)
                throw new NoSuchEntityExistsException("");

            if (await _borrowerRepository.HasApplicationsAsync(request.BorrowerId) is false)
                return new List<LoanResult>().AsEnumerable();

            var loans = await _loanRepository.GetLoansByBorrowerAsync(request.BorrowerId);

            return _mapper.Map<IEnumerable<LoanResult>>(loans);
        }
    }

    public class GetBorrowerLoansQueryValidator : AbstractValidator<GetBorrowerLoansQuery> {
        public GetBorrowerLoansQueryValidator() {
            RuleFor(x => x.BorrowerId)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
