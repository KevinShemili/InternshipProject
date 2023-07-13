using Application.UseCases.Authentication.Commands;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class AuthenticationMapping : Profile {
        public AuthenticationMapping() {
            CreateMap<RegisterCommand, User>()
                .ForMember(dest => dest.PasswordSalt, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Borrowers, opt => opt.Ignore())
                .ReverseMap();


        }
    }
}
