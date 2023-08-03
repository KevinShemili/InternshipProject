using Application.Persistance;
using Application.Persistance.Common;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.UnblockAccount.Command {

    public class UnblockAccountCommand : IRequest<bool> {
        public Guid Id { get; set; }
    }

    public class UnblockAccountCommandHandler : IRequestHandler<UnblockAccountCommand, bool> {

        private readonly IUserRepository _userRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public UnblockAccountCommandHandler(IUserRepository userRepository, IStringLocalizer<LocalizationResources> localizer, IUnitOfWork unitOfWork) {
            _userRepository = userRepository;
            _localizer = localizer;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UnblockAccountCommand request, CancellationToken cancellationToken) {
            if (await _userRepository.ContainsIdAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("UsernameDoesntExist").Value);

            await _userRepository.ResetTriesAsync(request.Id);
            await _userRepository.UnblockAccountAsync(request.Id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }

    public class UnblockAccountCommandValidator : AbstractValidator<UnblockAccountCommand> {
        public UnblockAccountCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
