using Application.Persistance;
using Application.Persistance.Common;
using Application.UseCases.ViewRoles.Results;
using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;

namespace Application.UseCases.Roles.Commands {

    public class CreateRoleCommand : IRequest<RoleResult> {
        public string Name { get; set; } = null!;
    }

    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, RoleResult> {

        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateRoleCommandHandler(IMapper mapper, IRoleRepository roleRepository, IUnitOfWork unitOfWork) {
            _mapper = mapper;
            _roleRepository = roleRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<RoleResult> Handle(CreateRoleCommand request, CancellationToken cancellationToken) {
            var role = _mapper.Map<Role>(request);
            role.Id = Guid.NewGuid();

            await _roleRepository.CreateAsync(role);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<RoleResult>(role);
        }
    }

    public class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand> {
        public CreateRoleCommandValidator() {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("EmptyRoleName");
        }
    }
}
