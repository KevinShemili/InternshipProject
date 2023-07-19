namespace Application.Services {
    public interface IRecoveryTokenService {
        public Task<string> GenerateVerificationToken();
        public Task<string> GeneratePasswordToken();
    }
}
