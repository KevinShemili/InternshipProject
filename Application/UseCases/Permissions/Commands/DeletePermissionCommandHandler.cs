using Application.Persistance;
using Application.Persistance.Common;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.Permissions.Commands {

    public class DeletePermissionCommand : IRequest<bool> {
        public Guid Id { get; set; }
    }

    public class DeletePermissionCommandHandler : IRequestHandler<DeletePermissionCommand, bool> {

        private readonly IPermissionRepository _permissionRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public DeletePermissionCommandHandler(IPermissionRepository permissionRepository, IStringLocalizer<LocalizationResources> localizer, IUnitOfWork unitOfWork) {
            _permissionRepository = permissionRepository;
            _localizer = localizer;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeletePermissionCommand request, CancellationToken cancellationToken) {
            if (await _permissionRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("PermissionDoesntExist").Value);

            await _permissionRepository.DeleteAsync(request.Id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }

    public class DeletePermissionCommandValidator : AbstractValidator<DeletePermissionCommand> {
        public DeletePermissionCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }

}
