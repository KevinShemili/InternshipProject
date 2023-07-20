using Application.Persistance;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;

namespace Application.UseCases.Roles.Commands {
    public class AssignationCommandHandler : IRequestHandler<AssignationCommand> {

        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public AssignationCommandHandler(IUserRepository userRepository, IMapper mapper, IRoleRepository roleRepository) {
            _userRepository = userRepository;
            _mapper = mapper;
            _roleRepository = roleRepository;
        }

        public async Task Handle(AssignationCommand request, CancellationToken cancellationToken) {

            var roles = await _roleRepository.GetAllAsync();
            var roleIds = roles.Select(x => x.Id).AsEnumerable();


            var flag = CheckList(roleIds, request.AssignIds);
            if (flag is not null)
                throw new NoSuchEntityExistsException($"Role with ID: \"{flag}\" does not exist");

            flag = CheckList(roleIds, request.UnassignIds);
            if (flag is not null)
                throw new NoSuchEntityExistsException($"Role with ID: \"{flag}\" does not exist");

            if (request.AssignIds.Any() is true
                && request.UnassignIds.Any() is true) {
                var assignRoles = GetRoles(request.AssignIds, roles);
                var unassignRoles = GetRoles(request.UnassignIds, roles);

                await _userRepository.UpdateRoles(request.UserId, assignRoles, unassignRoles);
            }
            else if (request.AssignIds.Any() is true
                && request.UnassignIds.Any() is false) {
                var assignRoles = GetRoles(request.AssignIds, roles);

                await _userRepository.AddRoles(request.UserId, assignRoles);
            }
            else if (request.AssignIds.Any() is false
                && request.UnassignIds.Any() is true) {
                var unassignRoles = GetRoles(request.UnassignIds, roles);

                await _userRepository.RemoveRoles(request.UserId, unassignRoles);
            }
            else {
                return;
            }
        }

        private Guid? CheckList(IEnumerable<Guid> roleIds, IEnumerable<Guid> checkIds) {
            foreach (var roleId in checkIds)
                if (roleIds.Contains(roleId) is false)
                    return roleId;
            return null;
        }

        private List<Role> GetRoles(IEnumerable<Guid> ids, IEnumerable<Role> roles) {
            var list = new List<Role>();
            foreach (var role in roles)
                if (ids.Contains(role.Id))
                    list.Add(role);
            return list;
        }

    }
}
