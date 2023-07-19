﻿using Application.Interfaces.Email;
using Application.Persistance;
using Application.Services;
using Domain.Exceptions;
using MediatR;

namespace Application.UseCases.ForgotPassword.Queries {
    public class ForgotPasswordQueryHandler : IRequestHandler<ForgotPasswordQuery> {

        private readonly IMailBodyService _mailBodyService;
        private readonly IUserRepository _userRepository;
        private readonly IMailService _mailService;
        private readonly IRecoveryTokenService _recoveryTokenService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;

        public ForgotPasswordQueryHandler(IMailBodyService mailBodyService, IUserRepository userRepository, IMailService mailService, IRecoveryTokenService recoveryTokenService, IUserVerificationAndResetRepository userVerificationAndResetRepository) {
            _mailBodyService = mailBodyService;
            _userRepository = userRepository;
            _mailService = mailService;
            _recoveryTokenService = recoveryTokenService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
        }

        public async Task Handle(ForgotPasswordQuery request, CancellationToken cancellationToken) {
            var entity = await _userRepository.ContainsEmail(request.Email);

            if (entity is false)
                throw new NoSuchUserExistsException("User does not exist");

            var token = await _recoveryTokenService.GeneratePasswordToken();

            await _userVerificationAndResetRepository.SetPasswordTokenAsync(request.Email, token, DateTime.Now.AddMinutes(15));

            var body = await _mailBodyService.GetForgotPasswordMailBody(request.Email, token);

            string subject = "Reset Password Request";

            var mailData = new MailData(request.Email, subject, body);
            await _mailService.SendAsync(mailData, cancellationToken);
        }
    }
}
