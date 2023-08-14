using Application.UseCases.LenderCases.Results;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class LenderMappings : Profile {
        public LenderMappings() {
            CreateMap<LenderQueryResult, Lender>().ReverseMap();

        }
    }
}
