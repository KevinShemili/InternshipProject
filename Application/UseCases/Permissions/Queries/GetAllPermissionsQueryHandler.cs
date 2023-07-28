using Application.Persistance;
using Application.UseCases.ViewPermissions.Results;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Application.UseCases.ViewPermissions.Queries {
    public class GetAllPermissionsQuery : IRequest<List<PermissionsResult>> {
    }

    public class GetAllPermissionsQueryHandler : IRequestHandler<GetAllPermissionsQuery, List<PermissionsResult>> {

        private readonly IPermissionRepository _permissionRepository;
        private readonly IMapper _mapper;

        public GetAllPermissionsQueryHandler(IPermissionRepository permissionRepository, IMapper mapper) {
            _permissionRepository = permissionRepository;
            _mapper = mapper;
        }

        public async Task<List<PermissionsResult>> Handle(GetAllPermissionsQuery request, CancellationToken cancellationToken) {
            var permissions = await _permissionRepository.GetAllAsync();

            var permissionsResult = _mapper.Map<List<PermissionsResult>>(permissions);
            return permissionsResult;
        }

        public class GetAllPermissionsQueryValidator : AbstractValidator<GetAllPermissionsQuery> {
            public GetAllPermissionsQueryValidator() { }
        }
    }
}
