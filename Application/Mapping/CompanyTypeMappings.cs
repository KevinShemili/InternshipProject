using Application.UseCases.CompanyTypeCases.Results;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class CompanyTypeMappings : Profile {
        public CompanyTypeMappings() {

            CreateMap<CompanyTypeResult, CompanyType>().ReverseMap();

        }
    }
}
