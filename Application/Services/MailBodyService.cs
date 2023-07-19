namespace Application.Services {
    public class MailBodyService : IMailBodyService {
        public async Task<string> GetVerificationMailBody(string email, string token) {

            string url = "https://localhost:44384";

            string htmlTemplate = await File.ReadAllTextAsync("C:\\Users\\User\\source\\repos\\InternshipProject\\Infrastructure\\Templates\\VerifyEmailTemplate.html");

            var body = htmlTemplate.Replace("ReplaceMe", $"{url}/auth/verify-email?token={token}&email={email}");

            return body;
        }

        public async Task<string> GetForgotUsernameMailBody(string username) {

            var htmlTemplate = await File.ReadAllTextAsync("C:\\Users\\User\\source\\repos\\InternshipProject\\Infrastructure\\Templates\\ForgotUsernameTemplate.html");

            var body = htmlTemplate.Replace("ReplaceMe", $"{username}");

            return body;
        }

        public async Task<string> GetForgotPasswordMailBody(string email, string token) {

            string url = "https://localhost:44384";

            string htmlTemplate = await File.ReadAllTextAsync("C:\\Users\\User\\source\\repos\\InternshipProject\\Infrastructure\\Templates\\ForgotPasswordTemplate.html");

            var body = htmlTemplate.Replace("ReplaceMe", $"{url}/auth/reset-password?token={token}&email={email}");

            return body;
        }

        public async Task<string> GetSuccessfulPasswordChangeMailBody() {

            string body = await File.ReadAllTextAsync("C:\\Users\\User\\source\\repos\\InternshipProject\\Infrastructure\\Templates\\SuccessPasswordChange.html");

            return body;
        }
    }
}
