using Application.Persistance;
using Application.Persistance.Common;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.Roles.Commands {

    public class DeleteRoleCommand : IRequest<bool> {
        public Guid Id { get; set; }
    }

    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, bool> {

        private readonly IRoleRepository _roleRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteRoleCommandHandler(IRoleRepository roleRepository,
            IStringLocalizer<LocalizationResources> localizer, IUnitOfWork unitOfWork) {
            _roleRepository = roleRepository;
            _localizer = localizer;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteRoleCommand request, CancellationToken cancellationToken) {
            if (await _roleRepository.ContainsAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("RoleDoesntExist").Value);

            await _roleRepository.DeleteAsync(request.Id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }

    public class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand> {
        public DeleteRoleCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
