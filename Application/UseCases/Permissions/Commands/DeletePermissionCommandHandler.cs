using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.Permissions.Commands {

    public class DeletePermissionCommand : IRequest {
        public Guid Id { get; set; }
    }

    public class DeletePermissionCommandHandler : IRequestHandler<DeletePermissionCommand> {

        private readonly IPermissionRepository _permissionRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;

        public DeletePermissionCommandHandler(IPermissionRepository permissionRepository, IStringLocalizer<LocalizationResources> localizer) {
            _permissionRepository = permissionRepository;
            _localizer = localizer;
        }

        public async Task Handle(DeletePermissionCommand request, CancellationToken cancellationToken) {
            if (await _permissionRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("PermissionDoesntExist").Value);

            await _permissionRepository.DeleteAsync(request.Id);
        }
    }

    public class DeletePermissionCommandValidator : AbstractValidator<DeletePermissionCommand> {
        public DeletePermissionCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }

}
