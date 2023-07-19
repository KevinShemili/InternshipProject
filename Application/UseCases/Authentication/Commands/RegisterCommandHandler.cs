using Application.Interfaces.Email;
using Application.Persistance;
using Application.Services;
using Application.UseCases.Authentication.Results;
using AutoMapper;
using Domain.Entities;
using Domain.Exceptions;
using MediatR;

namespace Application.UseCases.Authentication.Commands {
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResult> {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IHasherService _hasherService;
        private readonly IMailBodyService _mailBodyService;
        private readonly IRecoveryTokenService _recoveryTokenService;
        private readonly IMailService _mailService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;

        public RegisterCommandHandler(IUserRepository userRepository, IMapper mapper, IHasherService hasherService, IMailBodyService mailBodyService, IRecoveryTokenService recoveryTokenService, IMailService mailService, IUserVerificationAndResetRepository userVerificationAndResetRepository) {
            _userRepository = userRepository;
            _mapper = mapper;
            _hasherService = hasherService;
            _mailBodyService = mailBodyService;
            _recoveryTokenService = recoveryTokenService;
            _mailService = mailService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
        }

        public async Task<RegisterResult> Handle(RegisterCommand request, CancellationToken cancellationToken) {

            if (await _userRepository.ContainsEmail(request.Email) is true)
                throw new DuplicateException("Email already exists");

            if (await _userRepository.ContainsUsername(request.Username) is true)
                throw new DuplicateException("Username already exists");

            var tuple = _hasherService.HashPassword(request.Password);
            var hash = tuple.Item1;
            var salt = tuple.Item2;

            var user = _mapper.Map<User>(request);
            user.PasswordHash = hash;
            user.PasswordSalt = salt;
            user.IsEmailConfirmed = false;

            await _userRepository.CreateAsync(user);

            var token = await _recoveryTokenService.GenerateVerificationToken();
            var tokenExpiry = DateTime.Now.AddMinutes(30);

            var body = await _mailBodyService.GetVerificationMailBody(request.Email, token);

            await _userVerificationAndResetRepository.CreateAsync(new UserVerificationAndReset {
                EmailVerificationToken = token,
                EmailVerificationTokenExpiry = tokenExpiry,
                UserEmail = request.Email,
            });

            var subject = "Verify Your Email";
            var mailData = new MailData(request.Email, subject, body);
            await _mailService.SendAsync(mailData, cancellationToken);

            var returnResult = new RegisterResult {
                Id = user.Id,
                Username = user.Username
            };

            return returnResult;
        }
    }
}
