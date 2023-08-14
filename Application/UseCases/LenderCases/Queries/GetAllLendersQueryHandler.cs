using Application.Persistance;
using Application.UseCases.LenderCases.Results;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.UseCases.LenderCases.Queries {

    public class GetAllLendersQuery : IRequest<List<LenderQueryResult>> {
    }

    public class GetAllLendersQueryHandler : IRequestHandler<GetAllLendersQuery, List<LenderQueryResult>> {

        private readonly IMapper _mapper;
        private readonly ILenderRepository _lenderRepository;

        public GetAllLendersQueryHandler(ILenderRepository lenderRepository, IMapper mapper) {
            _lenderRepository = lenderRepository;
            _mapper = mapper;
        }

        public async Task<List<LenderQueryResult>> Handle(GetAllLendersQuery request, CancellationToken cancellationToken) {

            var lenders = await _lenderRepository.GetAllAsync();
            return _mapper.Map<List<LenderQueryResult>>(lenders);
        }
    }

    public class GetAllLendersQueryValidator : AbstractValidator<GetAllLendersQuery> {
        public GetAllLendersQueryValidator() {
        }
    }
}
