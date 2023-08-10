using Application.UseCases.ApplicationJourney.Commands;
using Application.UseCases.ApplicationJourney.Results;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class ApplicationMappings : Profile {
        public ApplicationMappings() {
            CreateMap<CreateApplicationCommand, ApplicationEntity>().ReverseMap();

            CreateMap<UpdateApplicationCommand, ApplicationEntity>().ReverseMap();

            CreateMap<ApplicationQueryResult, ApplicationEntity>().ReverseMap();
        }
    }
}
