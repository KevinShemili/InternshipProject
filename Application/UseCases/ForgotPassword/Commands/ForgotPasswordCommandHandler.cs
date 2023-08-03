using Application.Interfaces.Authentication;
using Application.Interfaces.Email;
using Application.Persistance;
using Application.Persistance.Common;
using Domain.Exceptions;
using FluentValidation;
using InternshipProject.Localizations;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Application.UseCases.ForgotPassword.Commands {

    public class ForgotPasswordCommand : IRequest<bool> {
        public string Email { get; set; } = null!;
    }

    public class ForgotPasswordCommandHandler : IRequestHandler<ForgotPasswordCommand, bool> {

        private readonly IMailBodyService _mailBodyService;
        private readonly IUserRepository _userRepository;
        private readonly IMailService _mailService;
        private readonly ITokenService _recoveryTokenService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;
        private readonly IStringLocalizer<LocalizationResources> _localizer;
        private readonly IUnitOfWork _unitOfWork;

        public ForgotPasswordCommandHandler(IMailBodyService mailBodyService, IUserRepository userRepository, IMailService mailService, ITokenService recoveryTokenService, IUserVerificationAndResetRepository userVerificationAndResetRepository, IStringLocalizer<LocalizationResources> localizer, IUnitOfWork unitOfWork) {
            _mailBodyService = mailBodyService;
            _userRepository = userRepository;
            _mailService = mailService;
            _recoveryTokenService = recoveryTokenService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
            _localizer = localizer;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken) {
            var entity = await _userRepository.ContainsEmailAsync(request.Email);

            if (entity is false)
                throw new NoSuchEntityExistsException(_localizer.GetString("EmailDoesntExist").Value);

            var token = await _recoveryTokenService.GeneratePasswordTokenAsync();

            await _userVerificationAndResetRepository.SetPasswordTokenAsync(request.Email, token, DateTime.Now.AddMinutes(15));

            var body = await _mailBodyService.GetForgotPasswordMailBodyAsync(request.Email, token);

            string subject = "Reset Password Request";

            var mailData = new MailData(request.Email, subject, body);
            await _mailService.SendAsync(mailData, cancellationToken);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }

    public class ForgotPasswordCommandValidator : AbstractValidator<ForgotPasswordCommand> {
        public ForgotPasswordCommandValidator() {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("EmptyEmail")
                .EmailAddress().WithMessage("EmailFormatRestriction");
        }
    }
}
