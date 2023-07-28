using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.Roles.Commands {

    public class DeleteRoleCommand : IRequest {
        public Guid Id { get; set; }
    }

    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand> {

        private readonly IRoleRepository _roleRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;

        public DeleteRoleCommandHandler(IRoleRepository roleRepository, IStringLocalizer<LocalizationResources> localizer) {
            _roleRepository = roleRepository;
            _localizer = localizer;
        }

        public async Task Handle(DeleteRoleCommand request, CancellationToken cancellationToken) {
            if (await _roleRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("RoleDoesntExist").Value);

            await _roleRepository.DeleteAsync(request.Id);
        }
    }

    public class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand> {
        public DeleteRoleCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
