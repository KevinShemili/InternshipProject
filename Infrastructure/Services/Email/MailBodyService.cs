using Application.Interfaces.Email;

namespace Application.Services {
    public class MailBodyService : IMailBodyService {

#pragma warning disable CS8601 // Possible null reference assignment.
        private readonly string currentDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
#pragma warning restore CS8601 // Possible null reference assignment.

        public async Task<string> GetVerificationMailBodyAsync(string email, string token) {

            string url = "https://localhost:58438";

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "VerifyEmailTemplate.html");
            string htmlTemplate = await File.ReadAllTextAsync(path);

            var body = htmlTemplate.Replace("ReplaceMe", $"{url}/auth/verify-email?token={token}&email={email}");

            return body;
        }

        public async Task<string> GetForgotUsernameMailBodyAsync(string username) {

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "ForgotUsernameTemplate.html");
            var htmlTemplate = await File.ReadAllTextAsync(path);

            var body = htmlTemplate.Replace("ReplaceMe", $"{username}");

            return body;
        }

        public async Task<string> GetForgotPasswordMailBodyAsync(string email, string token) {

            string url = "https://localhost:58438";

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "ForgotPasswordTemplate.html");
            string htmlTemplate = await File.ReadAllTextAsync(path);

            var body = htmlTemplate.Replace("ReplaceMe", $"{url}/auth/reset-password?token={token}&email={email}");

            return body;
        }

        public async Task<string> GetSuccessfulPasswordChangeMailBodyAsync() {

            var path = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "SuccessPasswordChange.html");
            string body = await File.ReadAllTextAsync(path);

            return body;
        }
    }
}
