using Application.UseCases.ApplicationJourney.Commands;
using Application.UseCases.ApplicationJourney.Results;
using Application.UseCases.Authentication.Commands;
using Application.UseCases.BlockedAccounts.Results;
using Application.UseCases.BorrowerJourney.Commands;
using Application.UseCases.BorrowerJourney.Results;
using Application.UseCases.Permissions.Commands;
using Application.UseCases.Roles.Commands;
using Application.UseCases.ViewPermissions.Results;
using Application.UseCases.ViewRoles.Results;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class Mappings : Profile {
        public Mappings() {
            CreateMap<RegisterCommand, User>()
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
                .ReverseMap();

            CreateMap<PermissionsResult, Permission>().ReverseMap();
            CreateMap<RoleResult, Role>().ReverseMap();
            CreateMap<CreatePermissionCommand, Permission>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<CreateRoleCommand, Role>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
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
            CreateMap<CreateBorrowerCommmand, Borrower>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.UserId, opt => opt.Ignore())
                .ForMember(dest => dest.CompanyTypeId, opt => opt.Ignore())
                .ForMember(dest => dest.CompanyType, opt => opt.Ignore())
                .ForMember(dest => dest.CompanyProfile, opt => opt.Ignore())
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<BorrowerCommandResult, Borrower>().ReverseMap();
            CreateMap<BorrowerQueryResult, Borrower>().ReverseMap();
            CreateMap<UpdateBorrowerCommand, Borrower>().ReverseMap()
                .ForMember(dest => dest.CompanyType, opt => opt.Ignore());
            CreateMap<CreateApplicationCommand, ApplicationEntity>().ReverseMap();
            CreateMap<UpdateApplicationCommand, ApplicationEntity>().ReverseMap();
            CreateMap<ApplicationQueryResult, ApplicationEntity>().ReverseMap();
        }
    }
}
