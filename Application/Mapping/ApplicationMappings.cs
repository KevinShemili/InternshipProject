using Application.UseCases.ApplicationJourney.Commands;
using Application.UseCases.ApplicationJourney.Results;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class ApplicationMappings : Profile {
        public ApplicationMappings() {
            CreateMap<CreateApplicationCommand, ApplicationEntity>().ReverseMap();

            CreateMap<UpdateApplicationCommand, ApplicationEntity>().ReverseMap();

            CreateMap<ApplicationEntity, ApplicationQueryResult>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.ApplicationStatus.Name))
                .ReverseMap();

        }
    }
}
