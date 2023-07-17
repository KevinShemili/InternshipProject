using Application.UseCases.Authentication.Commands;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class AuthenticationMapping : Profile {
        public AuthenticationMapping() {
            CreateMap<RegisterCommand, User>()
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
                .ReverseMap();
        }
    }
}
