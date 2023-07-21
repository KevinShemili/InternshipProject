using Application.Persistance;
using Domain.Entities;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.Roles.Commands {

    public class RoleAssignationCommand : IRequest {
        public Guid UserId { get; set; }
        public List<Guid> Ids { get; set; } = null!;
    }

    public class RoleAssignationCommandHandler : IRequestHandler<RoleAssignationCommand> {

        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;

        public RoleAssignationCommandHandler(IUserRepository userRepository, IRoleRepository roleRepository) {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public async Task Handle(RoleAssignationCommand request, CancellationToken cancellationToken) {

            if (request.Ids.Any() is false)
                await _userRepository.ClearRolesAsync(request.UserId);

            var roles = await _roleRepository.GetAllAsync();
            var roleIds = roles.Select(x => x.Id).AsEnumerable();

            // Check if provided id values exist in database
            var flag = request.Ids.All(item => roleIds.Contains(item));

            if (flag is false)
                throw new NoSuchEntityExistsException($"Invalid roles list");

            await _userRepository.UpdateRolesAsync(request.UserId, GetRoles(request.Ids, roles));
        }

        // we are getting a list of Ids, we need to get the entities associated with these ids in order to perform the insertion in the db
        private List<Role> GetRoles(IEnumerable<Guid> ids, IEnumerable<Role> roles) {
            var list = new List<Role>();
            foreach (var role in roles)
                if (ids.Contains(role.Id))
                    list.Add(role);
            return list;
        }
    }

    public class RoleAssignationCommandValidator : AbstractValidator<RoleAssignationCommand> {
        public RoleAssignationCommandValidator() {
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("User ID cannot be empty");
        }
    }
}
