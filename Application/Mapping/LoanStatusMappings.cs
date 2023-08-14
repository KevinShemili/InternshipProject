using Application.UseCases.StatusCases.Results;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class LoanStatusMappings : Profile {
        public LoanStatusMappings() {

            CreateMap<LoanStatusResult, LoanStatus>().ReverseMap();

        }
    }
}
