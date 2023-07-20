using Application.Persistance;
using Application.UseCases.ViewPermissions.Results;
using AutoMapper;
using MediatR;

namespace Application.UseCases.Permissions.Queries {
    public class RolePermissionsQueryHandler : IRequestHandler<RolePermissionsQuery, List<PermissionsResult>> {

        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RolePermissionsQueryHandler(IRoleRepository roleRepository, IMapper mapper) {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<List<PermissionsResult>> Handle(RolePermissionsQuery request, CancellationToken cancellationToken) {
            var permissions = await _roleRepository.GetPermissionsAsync(request.Id);

            var result = _mapper.Map<List<PermissionsResult>>(permissions.ToList());
            return result;
        }
    }
}
