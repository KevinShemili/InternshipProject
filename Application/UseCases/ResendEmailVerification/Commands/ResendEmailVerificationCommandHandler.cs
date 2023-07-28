using Application.Interfaces.Authentication;
using Application.Interfaces.Email;
using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.ResendEmailVerification.Commands {

    public class ResendEmailVerificationCommand : IRequest {
        public string Email { get; set; } = null!;
    }

    public class ResendEmailVerificationCommandHandler : IRequestHandler<ResendEmailVerificationCommand> {

        private readonly IMailBodyService _mailBodyService;
        private readonly IMailService _mailService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;
        private readonly ITokenService _recoveryTokenService;
        private readonly IStringLocalizer<LocalizationResources> _localizer;

        public ResendEmailVerificationCommandHandler(IMailBodyService mailBodyService, IMailService mailService, IUserVerificationAndResetRepository userVerificationAndResetRepository, ITokenService recoveryTokenService, IStringLocalizer<LocalizationResources> localizer) {
            _mailBodyService = mailBodyService;
            _mailService = mailService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
            _recoveryTokenService = recoveryTokenService;
            _localizer = localizer;
        }

        public async Task Handle(ResendEmailVerificationCommand request, CancellationToken cancellationToken) {

            var flag = await _userVerificationAndResetRepository.ContainsEmailAsync(request.Email);

            if (flag is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("EmailDoesntExist").Value);

            var token = await _recoveryTokenService.GenerateVerificationTokenAsync();
            var tokenExpiry = DateTime.Now.AddMinutes(30);

            var body = await _mailBodyService.GetVerificationMailBodyAsync(request.Email, token);

            await _userVerificationAndResetRepository.UpdateVerificationTokenAsync(request.Email, token, tokenExpiry);

            var subject = "Verify Your Email";
            var mailData = new MailData(request.Email, subject, body);

            await _mailService.SendAsync(mailData, cancellationToken);
        }
    }

    public class ResendEmailVerificationCommandValidator : AbstractValidator<ResendEmailVerificationCommand> {
        public ResendEmailVerificationCommandValidator() {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("EmptyEmail")
                .EmailAddress().WithMessage("EmailFormatRestriction");
        }
    }
}
