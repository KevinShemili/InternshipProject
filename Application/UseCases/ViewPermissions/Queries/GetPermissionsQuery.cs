using Application.Persistance;
using Application.UseCases.ViewPermissions.Results;
using AutoMapper;
using MediatR;

namespace Application.UseCases.ViewPermissions.Queries {
    public class GetPermissionsQuery : IRequestHandler<EmptyPermissionClassQuery, List<PermissionResult>> {

        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;

        public GetPermissionsQuery(IPermissionRepository permissionRepository, IMapper mapper) {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }

        public async Task<List<PermissionResult>> Handle(EmptyPermissionClassQuery request, CancellationToken cancellationToken) {
            var permissions = await _permissionRepository.GetAllAsync();

            var permissionsResult = _mapper.Map<List<PermissionResult>>(permissions);
            return permissionsResult;
        }
    }
}
