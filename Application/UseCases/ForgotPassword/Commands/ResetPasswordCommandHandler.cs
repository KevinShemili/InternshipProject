using Application.Interfaces.Email;
using Application.Persistance;
using Application.Services;
using Domain.Exceptions;
using MediatR;

namespace Application.UseCases.ForgotPassword.Commands {
    public class ResetPasswordCommandHandler : IRequestHandler<ResetPasswordCommand> {

        private readonly IUserRepository _userRepository;
        private readonly IMailService _mailService;
        private readonly IMailBodyService _mailBodyService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;
        private readonly IHasherService _hasherService;

        public ResetPasswordCommandHandler(IUserRepository userRepository, IMailService mailService, IMailBodyService mailBodyService, IUserVerificationAndResetRepository userVerificationAndResetRepository, IHasherService hasherService) {
            _userRepository = userRepository;
            _mailService = mailService;
            _mailBodyService = mailBodyService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
            _hasherService = hasherService;
        }

        public async Task Handle(ResetPasswordCommand request, CancellationToken cancellationToken) {

            var entity = await _userVerificationAndResetRepository.GetByEmailAsync(request.Email);

            var passwordToken = entity.PasswordResetToken;
            var passwordTokenExpiry = entity.PasswordResetTokenExpiry;

            if (passwordToken is null)
                throw new ForbiddenException("Invalid token");

            if (passwordTokenExpiry is null)
                throw new ForbiddenException("Invalid token");

            if (passwordToken == request.Token
                && passwordTokenExpiry > DateTime.Now) {
                var tuple = _hasherService.HashPassword(request.Password);
                var passwordHash = tuple.Item1;
                var passwordSalt = tuple.Item2;

                await _userRepository.ChangePassword(request.Email, passwordHash, passwordSalt);

                var body = await _mailBodyService.GetSuccessfulPasswordChangeMailBody();
                var subject = "Password Reset";
                var mailData = new MailData(request.Email, subject, body);
                await _mailService.SendAsync(mailData, cancellationToken);
            }
            else if (passwordToken == request.Token
                && passwordTokenExpiry < DateTime.Now)
                throw new TokenExpiredException("Token has expired");
            else
                throw new ForbiddenException("Invalid token");


        }
    }
}
