using Application.Persistance;
using Application.UseCases.CompanyTypeCases.Results;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.UseCases.CompanyTypeCases.Queries {

    public class GetAllCompanyTypesQuery : IRequest<IEnumerable<CompanyTypeResult>> {

    }

    public class GetAllCompanyTypesQueryHandler : IRequestHandler<GetAllCompanyTypesQuery, IEnumerable<CompanyTypeResult>> {

        private readonly ICompanyTypeRepository _companyTypeRepository;
        private readonly IMapper _mapper;

        public GetAllCompanyTypesQueryHandler(ICompanyTypeRepository companyTypeRepository, IMapper mapper) {
            _companyTypeRepository = companyTypeRepository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<CompanyTypeResult>> Handle(GetAllCompanyTypesQuery request, CancellationToken cancellationToken) {

            var companyTypes = await _companyTypeRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CompanyTypeResult>>(companyTypes);
        }
    }

    public class GetAllCompanyTypesQueryValidator : AbstractValidator<GetAllCompanyTypesQuery> {
        public GetAllCompanyTypesQueryValidator() {

        }
    }
}
