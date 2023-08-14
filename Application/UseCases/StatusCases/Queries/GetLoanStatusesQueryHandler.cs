using Application.Persistance;
using Application.UseCases.StatusCases.Results;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.UseCases.StatusCases.Queries {

    public class GetLoanStatusesQuery : IRequest<IEnumerable<LoanStatusResult>> {

    }


    public class GetLoanStatusesQueryHandler : IRequestHandler<GetLoanStatusesQuery, IEnumerable<LoanStatusResult>> {

        private readonly ILoanStatusRepository _loanStatusRepository;
        private readonly IMapper _mapper;

        public GetLoanStatusesQueryHandler(ILoanStatusRepository loanStatusRepository, IMapper mapper) {
            _loanStatusRepository = loanStatusRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LoanStatusResult>> Handle(GetLoanStatusesQuery request, CancellationToken cancellationToken) {

            var statuses = await _loanStatusRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<LoanStatusResult>>(statuses);
        }
    }

    public class GetLoanStatusesQueryValidator : AbstractValidator<GetLoanStatusesQuery> {
        public GetLoanStatusesQueryValidator() {
        }
    }
}
