using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.UnblockAccount.Command {

    public class UnblockAccountCommand : IRequest {
        public Guid Id { get; set; }
    }

    public class UnblockAccountCommandHandler : IRequestHandler<UnblockAccountCommand> {

        private readonly IUserRepository _userRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;

        public UnblockAccountCommandHandler(IUserRepository userRepository, IStringLocalizer<LocalizationResources> localizer) {
            _userRepository = userRepository;
            _localizer = localizer;
        }

        public async Task Handle(UnblockAccountCommand request, CancellationToken cancellationToken) {
            if (await _userRepository.ContainsIdAsync(request.Id) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("UsernameDoesntExist").Value);

            await _userRepository.ResetTriesAsync(request.Id);
            await _userRepository.UnblockAccountAsync(request.Id);
        }
    }

    public class UnblockAccountCommandValidator : AbstractValidator<UnblockAccountCommand> {
        public UnblockAccountCommandValidator() {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("EmptyId");
        }
    }
}
