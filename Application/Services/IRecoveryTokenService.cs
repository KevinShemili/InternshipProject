namespace Application.Services {
    public interface IRecoveryTokenService {
        Task<string> GenerateVerificationTokenAsync();
        Task<string> GeneratePasswordTokenAsync();
    }
}
