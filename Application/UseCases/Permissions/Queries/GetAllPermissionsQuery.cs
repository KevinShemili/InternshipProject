using Application.Persistance;
using Application.UseCases.ViewPermissions.Results;
using AutoMapper;
using MediatR;

namespace Application.UseCases.ViewPermissions.Queries {
    public class GetAllPermissionsQuery : IRequestHandler<EmptyPermissionClassQuery, List<PermissionsResult>> {

        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;

        public GetAllPermissionsQuery(IPermissionRepository permissionRepository, IMapper mapper) {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }

        public async Task<List<PermissionsResult>> Handle(EmptyPermissionClassQuery request, CancellationToken cancellationToken) {
            var permissions = await _permissionRepository.GetAllAsync();

            var permissionsResult = _mapper.Map<List<PermissionsResult>>(permissions);
            return permissionsResult;
        }
    }
}
