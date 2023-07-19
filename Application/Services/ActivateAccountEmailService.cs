using Application.Interfaces.Email;
using Application.Persistance;
using Application.UseCases.Authentication.Commands;
using Domain.Entities;
using Domain.Exceptions;
using System.Security.Cryptography;

namespace Application.Services {
    public class ActivateAccountEmailService : IActivateAccountEmailService {

        private readonly IMailService _mailService;
        private readonly IUserVerificationAndResetRepository _userVerificationAndResetRepository;


        public ActivateAccountEmailService(IMailService mailService, IUserVerificationAndResetRepository userVerificationAndResetRepository) {
            _mailService = mailService;
            _userVerificationAndResetRepository = userVerificationAndResetRepository;
        }

        public async Task<bool> SendActivationEmail(RegisterCommand request, CancellationToken cancellationToken) {

            var tupleMailData = await PrepareMailData(request.Email);

            var mailData = tupleMailData.Item1;
            var verificationToken = tupleMailData.Item2;
            var verificationTokenTimeOut = DateTime.Now.AddMinutes(30);

            await _userVerificationAndResetRepository.CreateAsync(new UserVerificationAndReset {
                EmailVerificationToken = verificationToken,
                EmailVerificationTokenExpiry = verificationTokenTimeOut,
                UserEmail = request.Email,
            });

            await _mailService.SendAsync(mailData, cancellationToken);
            return true;
        }

        public async Task<bool> ResendActivationEmail(string email, CancellationToken cancellationToken) {
            var flag = await _userVerificationAndResetRepository.ContainsEmail(email);

            if (flag is false)
                throw new NoSuchUserExistsException("Invalid email");

            var tupleMailData = await PrepareMailData(email);
            var mailData = tupleMailData.Item1;
            var verificationToken = tupleMailData.Item2;
            var verificationTokenTimeOut = DateTime.Now.AddMinutes(30);

            await _userVerificationAndResetRepository.UpdateVerificationTokens(email, verificationToken, verificationTokenTimeOut);

            await _mailService.SendAsync(mailData, cancellationToken);

            return true;
        }

        private async Task<Tuple<MailData, string>> PrepareMailData(string email) {
            List<string> To = new List<string> {
                email
            };

            string token = await GenerateToken();

            string url = "https://localhost:44384";
            string subject = "Verify Your Email";

            // should be changed to relative 
            string htmlTemplate = File.ReadAllText("C:\\Users\\User\\source\\repos\\InternshipProject\\Infrastructure\\Templates\\VerifyEmailTemplate.html");

            htmlTemplate = htmlTemplate.Replace("ReplaceMe", $"{url}/auth/verify-email?token={token}&email={email}");
            var body = htmlTemplate;
            var mailData = new MailData(To, subject, body);

            return Tuple.Create(mailData, token);
        }

        private async Task<string> GenerateToken() {
            string token;

            do {
                token = Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
            }
            while (await _userVerificationAndResetRepository.ContainsVerificationToken(token)); // check if such token already exists
            return token;
        }
    }
}
