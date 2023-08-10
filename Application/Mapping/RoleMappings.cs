using Application.UseCases.Roles.Commands;
using Application.UseCases.ViewRoles.Results;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping {
    public class RoleMappings : Profile {
        public RoleMappings() {
            CreateMap<RoleResult, Role>().ReverseMap();

            CreateMap<CreateRoleCommand, Role>()
                           .ForMember(dest => dest.Id, opt => opt.Ignore())
                           .ReverseMap();
        }
    }
}
