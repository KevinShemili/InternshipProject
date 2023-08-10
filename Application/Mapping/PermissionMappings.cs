using Application.UseCases.Permissions.Commands;
using Application.UseCases.ViewPermissions.Results;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class PermissionMappings : Profile {
        public PermissionMappings() {
            CreateMap<PermissionsResult, Permission>().ReverseMap();

            CreateMap<CreatePermissionCommand, Permission>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
