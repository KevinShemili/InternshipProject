using Application.UseCases.Authentication.Commands;
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
        }
    }
}
