using Application.Interfaces.Email;

namespace Application.Services {
    public class MailBodyService : IMailBodyService {

#pragma warning disable CS8601 // Possible null reference assignment.
        private readonly string currentDirectory = Path.GetDirectoryName(Environment.CurrentDirectory);
#pragma warning restore CS8601 // Possible null reference assignment.

        public async Task<string> GetVerificationMailBodyAsync(string email, string token) {

            string url = "https://localhost:44384";

            string filePath = System.IO.Path.Combine(currentDirectory, @"Infrastructure\Templates\VerifyEmailTemplate.html");
            string fullPath = Path.GetFullPath(filePath);
            string htmlTemplate = await File.ReadAllTextAsync(fullPath);

            var body = htmlTemplate.Replace("ReplaceMe", $"{url}/auth/verify-email?token={token}&email={email}");

            return body;
        }

        public async Task<string> GetForgotUsernameMailBodyAsync(string username) {

            string filePath = System.IO.Path.Combine(currentDirectory, @"Infrastructure\Templates\ForgotUsernameTemplate.html");
            string fullPath = Path.GetFullPath(filePath);

            var htmlTemplate = await File.ReadAllTextAsync(fullPath);

            var body = htmlTemplate.Replace("ReplaceMe", $"{username}");

            return body;
        }

        public async Task<string> GetForgotPasswordMailBodyAsync(string email, string token) {

            string url = "https://localhost:44384";

            string filePath = System.IO.Path.Combine(currentDirectory, @"Infrastructure\Templates\ForgotPasswordTemplate.html");
            string fullPath = Path.GetFullPath(filePath);

            string htmlTemplate = await File.ReadAllTextAsync(fullPath);

            var body = htmlTemplate.Replace("ReplaceMe", $"{url}/auth/reset-password?token={token}&email={email}");

            return body;
        }

        public async Task<string> GetSuccessfulPasswordChangeMailBodyAsync() {

            string filePath = System.IO.Path.Combine(currentDirectory, @"Infrastructure\Templates\SuccessPasswordChange.html");
            string fullPath = Path.GetFullPath(filePath);

            string body = await File.ReadAllTextAsync(fullPath);

            return body;
        }
    }
}
