using Application.UseCases.Authentication.Commands;
using Application.UseCases.BlockedAccounts.Results;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class UserMappings : Profile {
        public UserMappings() {
            CreateMap<RegisterCommand, User>()
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
                .ReverseMap();

            CreateMap<BlockedAccountResult, User>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.FirstName, opt => opt.Ignore())
                .ForMember(dest => dest.LastName, opt => opt.Ignore())
                .ForMember(dest => dest.IsEmailConfirmed, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordHash, opt => opt.Ignore())
                .ForMember(dest => dest.PasswordSalt, opt => opt.Ignore())
                .ForMember(dest => dest.LoginTries, opt => opt.Ignore())
                .ForMember(dest => dest.IsBlocked, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
