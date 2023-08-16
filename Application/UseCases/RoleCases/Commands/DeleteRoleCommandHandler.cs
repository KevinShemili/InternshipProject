using Application.Exceptions.ClientErrors;
using Application.Exceptions.ServerErrors;
using Application.Persistance;
using Application.Persistance.Common;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.Roles.Commands {

    public class DeleteRoleCommand : IRequest<bool> {
        public Guid RoleId { get; set; }
    }

    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, bool> {

        private readonly IRoleRepository _roleRepository;
        private readonly IStringLocalizer<LocalizationResources> _localization;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteRoleCommandHandler(IRoleRepository roleRepository,
            IStringLocalizer<LocalizationResources> localizer, IUnitOfWork unitOfWork) {
            _roleRepository = roleRepository;
            _localization = localizer;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteRoleCommand request, CancellationToken cancellationToken) {
            if (await _roleRepository.ContainsAsync(request.RoleId) is false)
                throw new NotFoundException(_localization.GetString("RoleDoesntExist").Value);

            await _roleRepository.DeleteAsync(request.RoleId);

            var flag = await _unitOfWork.SaveChangesAsync();
            if (flag is false)
                throw new DatabaseException(_localization.GetString("DatabaseException").Value);

            return true;
        }
    }

    public class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand> {
        public DeleteRoleCommandValidator() {
            RuleFor(x => x.RoleId)
                .NotEmpty().WithMessage("EmptyRoleId");
        }
    }
}
