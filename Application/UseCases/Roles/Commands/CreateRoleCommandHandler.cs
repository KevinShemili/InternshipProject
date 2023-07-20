using Application.Persistance;
using Application.UseCases.ViewRoles.Results;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.UseCases.Roles.Commands {
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, RoleResult> {

        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public CreateRoleCommandHandler(IMapper mapper, IRoleRepository roleRepository) {
            _mapper = mapper;
            _roleRepository = roleRepository;
        }

        public async Task<RoleResult> Handle(CreateRoleCommand request, CancellationToken cancellationToken) {
            var role = _mapper.Map<Role>(request);
            role.Id = Guid.NewGuid();

            await _roleRepository.CreateAsync(role);

            return _mapper.Map<RoleResult>(role);
        }
    }
}
