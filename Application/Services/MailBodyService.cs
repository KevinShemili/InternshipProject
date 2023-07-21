namespace Application.Services {
    public class MailBodyService : IMailBodyService {
        public async Task<string> GetVerificationMailBodyAsync(string email, string token) {

            string url = "https://localhost:44384";

            string htmlTemplate = await File.ReadAllTextAsync("C:\\Users\\User\\source\\repos\\InternshipProject\\Infrastructure\\Templates\\VerifyEmailTemplate.html");

            var body = htmlTemplate.Replace("ReplaceMe", $"{url}/auth/verify-email?token={token}&email={email}");

            return body;
        }

        public async Task<string> GetForgotUsernameMailBodyAsync(string username) {

            var htmlTemplate = await File.ReadAllTextAsync("C:\\Users\\User\\source\\repos\\InternshipProject\\Infrastructure\\Templates\\ForgotUsernameTemplate.html");

            var body = htmlTemplate.Replace("ReplaceMe", $"{username}");

            return body;
        }

        public async Task<string> GetForgotPasswordMailBodyAsync(string email, string token) {

            string url = "https://localhost:44384";

            string htmlTemplate = await File.ReadAllTextAsync("C:\\Users\\User\\source\\repos\\InternshipProject\\Infrastructure\\Templates\\ForgotPasswordTemplate.html");

            var body = htmlTemplate.Replace("ReplaceMe", $"{url}/auth/reset-password?token={token}&email={email}");

            return body;
        }

        public async Task<string> GetSuccessfulPasswordChangeMailBodyAsync() {

            string body = await File.ReadAllTextAsync("C:\\Users\\User\\source\\repos\\InternshipProject\\Infrastructure\\Templates\\SuccessPasswordChange.html");

            return body;
        }
    }
}
