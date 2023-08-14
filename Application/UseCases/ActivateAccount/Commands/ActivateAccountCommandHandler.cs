using Application.Exceptions;
using Application.Exceptions.ServerErrors;
using Application.Persistance;
using Application.Persistance.Common;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.ActivateAccount.Commands {

    public class ActivateAccountCommand : IRequest<bool> {
        public string Token { get; set; } = null!;
        public string Email { get; set; } = null!;
    }

    public class ActivateAccountCommandHandler : IRequestHandler<ActivateAccountCommand, bool> {

        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;
        private readonly IUserRepository _userRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public ActivateAccountCommandHandler(IUserVerificationAndResetRepository userVerificationAndResetRepository,
                                             IUserRepository userRepository,
                                             IStringLocalizer<LocalizationResources> localizer,
                                             IUnitOfWork unitOfWork) {
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
            _userRepository = userRepository;
            _localizer = localizer;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(ActivateAccountCommand request, CancellationToken cancellationToken) {

            if (await _userVerificationAndResetRepository.ContainsEmailAsync(request.Email) is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("EmailDoesntExist").Value);

            if (await _userRepository.IsAccountActivatedAsync(request.Email) is true)
                throw new EmailAlreadyVerifiedException(_localizer.GetString("EmailAlreadyVerified").Value);

            var entity = await _userVerificationAndResetRepository.GetByEmailAsync(request.Email);

            var verificationToken = entity.EmailVerificationToken;
            var verificationTokenExpiry = entity.EmailVerificationTokenExpiry;

            if (verificationToken is null)
                throw new ForbiddenException(_localizer.GetString("EmptyVerificationTokens").Value);

            if (verificationTokenExpiry is null)
                throw new ForbiddenException(_localizer.GetString("EmptyVerificationTokens").Value);

            if (verificationToken == request.Token
                && verificationTokenExpiry > DateTime.Now)
                await _userRepository.ActivateAccountAsync(request.Email);
            else if (verificationToken == request.Token
                && verificationTokenExpiry < DateTime.Now) // token is expired
                throw new TokenExpiredException(_localizer.GetString("TokenExpired").Value);
            else // token is invalid
                throw new ForbiddenException(_localizer.GetString("InvalidToken").Value);

            var flag = await _unitOfWork.SaveChangesAsync();

            if (flag is false)
                throw new DatabaseException(_localizer.GetString("DatabaseException").Value);

            return true;
        }
    }

    public class ActivateCommandValidator : AbstractValidator<ActivateAccountCommand> {
        public ActivateCommandValidator() {
            RuleFor(x => x.Token)
                .NotEmpty().WithMessage("EmptyToken");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("EmptyEmail")
                .EmailAddress().WithMessage("EmailFormatRestriction");
        }
    }
}
