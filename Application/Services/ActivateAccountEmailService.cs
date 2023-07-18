using Application.Interfaces.Email;
using Application.Persistance;
using Application.UseCases.Authentication.Commands;
using Domain.Entities;
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

            var tupleMailData = PrepareMailData(request);

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

        private Tuple<MailData, string> PrepareMailData(RegisterCommand request) {
            List<string> To = new List<string> {
                request.Email
            };

            string token = GenerateToken();

            string url = "https://localhost:44384";
            string subject = "Verify Your Email";

            // should be changed to relative 
            string htmlTemplate = File.ReadAllText("C:\\Users\\User\\source\\repos\\InternshipProject\\Infrastructure\\Templates\\VerifyEmailTemplate.html");

            htmlTemplate = htmlTemplate.Replace("ReplaceMe", $"{url}/auth/verify-email?token={token}&email={request.Email}");
            var body = htmlTemplate;
            var mailData = new MailData(To, subject, body);

            return Tuple.Create(mailData, token);
        }

        private string GenerateToken() {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }
    }
}
