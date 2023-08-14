using Application.Persistance;
using Application.UseCases.LoanJourney.Results;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.UseCases.LoanJourney.Queries {

    public class GetAllLoansQuery : IRequest<List<LoanResult>> {

    }


    public class GetAllLoansQueryHandler : IRequestHandler<GetAllLoansQuery, List<LoanResult>> {

        private readonly ILoanRepository _loanRepository;
        private readonly IMapper _mapper;

        public GetAllLoansQueryHandler(ILoanRepository loanRepository, IMapper mapper) {
            _loanRepository = loanRepository;
            _mapper = mapper;
        }

        public async Task<List<LoanResult>> Handle(GetAllLoansQuery request, CancellationToken cancellationToken) {

            var loans = await _loanRepository.GetAllAsync();

            return _mapper.Map<List<LoanResult>>(loans);
        }
    }

    public class GetAllLoansQueryValidator : AbstractValidator<GetAllLoansQuery> {
        public GetAllLoansQueryValidator() {
        }
    }
}
