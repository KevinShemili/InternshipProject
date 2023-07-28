using Application.Interfaces.Email;

namespace Application.Services {
    public class MailBodyService : IMailBodyService {

        private const string URL = "https://localhost:58438";

        public async Task<string> GetVerificationMailBodyAsync(string email, string token) {

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "VerifyEmailTemplate.html");
            string htmlTemplate = await File.ReadAllTextAsync(path);

            var body = htmlTemplate.Replace("ReplaceMe", $"{URL}/auth/verify-email?token={token}&email={email}");

            return body;
        }

        public async Task<string> GetForgotUsernameMailBodyAsync(string username) {

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "ForgotUsernameTemplate.html");
            var htmlTemplate = await File.ReadAllTextAsync(path);

            var body = htmlTemplate.Replace("ReplaceMe", $"{username}");

            return body;
        }

        public async Task<string> GetForgotPasswordMailBodyAsync(string email, string token) {

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "ForgotPasswordTemplate.html");
            string htmlTemplate = await File.ReadAllTextAsync(path);

            var body = htmlTemplate.Replace("ReplaceMe", $"{URL}/auth/reset-password?token={token}&email={email}");

            return body;
        }

        public async Task<string> GetSuccessfulPasswordChangeMailBodyAsync() {

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "SuccessPasswordChange.html");
            string body = await File.ReadAllTextAsync(path);

            return body;
        }
    }
}
