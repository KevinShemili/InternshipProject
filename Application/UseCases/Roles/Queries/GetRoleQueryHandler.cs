using Application.Persistance;
using Application.UseCases.ViewRoles.Results;
using AutoMapper;
using MediatR;

namespace Application.UseCases.ViewPermissions.Queries {

    public class GetRoleQuery : IRequest<List<RoleResult>> {
    }

    public class GetRoleQueryHandler : IRequestHandler<GetRoleQuery, List<RoleResult>> {

        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public GetRoleQueryHandler(IRoleRepository roleRepository, IMapper mapper) {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<List<RoleResult>> Handle(GetRoleQuery request, CancellationToken cancellationToken) {
            var permissions = await _roleRepository.GetAllAsync();

            var permissionsResult = _mapper.Map<List<RoleResult>>(permissions);
            return permissionsResult;
        }
    }
}
