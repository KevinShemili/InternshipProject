using Application.Interfaces.Authentication;
using Application.Interfaces.Email;
using Application.Persistance;
using Domain.Exceptions;
using FluentValidation;
using MediatR;

namespace Application.UseCases.ForgotPassword.Queries
{

    public class ForgotPasswordQuery : IRequest {
        public string Email { get; set; } = null!;
    }

    public class ForgotPasswordQueryHandler : IRequestHandler<ForgotPasswordQuery> {

        private readonly IMailBodyService _mailBodyService;
        private readonly IUserRepository _userRepository;
        private readonly IMailService _mailService;
        private readonly ITokenService _recoveryTokenService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;

        public ForgotPasswordQueryHandler(IMailBodyService mailBodyService, IUserRepository userRepository, IMailService mailService, ITokenService recoveryTokenService, IUserVerificationAndResetRepository userVerificationAndResetRepository) {
            _mailBodyService = mailBodyService;
            _userRepository = userRepository;
            _mailService = mailService;
            _recoveryTokenService = recoveryTokenService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
        }

        public async Task Handle(ForgotPasswordQuery request, CancellationToken cancellationToken) {
            var entity = await _userRepository.ContainsEmailAsync(request.Email);

            if (entity is false)
                throw new NoSuchEntityExistsException("User does not exist");

            var token = await _recoveryTokenService.GeneratePasswordTokenAsync();

            await _userVerificationAndResetRepository.SetPasswordTokenAsync(request.Email, token, DateTime.Now.AddMinutes(15));

            var body = await _mailBodyService.GetForgotPasswordMailBodyAsync(request.Email, token);

            string subject = "Reset Password Request";

            var mailData = new MailData(request.Email, subject, body);
            await _mailService.SendAsync(mailData, cancellationToken);
        }
    }

    public class ForgotPasswordQueryValidator : AbstractValidator<ForgotPasswordQuery> {
        public ForgotPasswordQueryValidator() {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email cannot be empty")
                .EmailAddress().WithMessage("Email format johndoe@mail.com");
        }
    }
}
