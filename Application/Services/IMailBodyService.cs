namespace Application.Services {
    public interface IMailBodyService {
        public Task<string> GetVerificationMailBody(string email, string token);
        public Task<string> GetForgotUsernameMailBody(string email);
        public Task<string> GetForgotPasswordMailBody(string email, string token);
        public Task<string> GetSuccessfulPasswordChangeMailBody();
    }
}
