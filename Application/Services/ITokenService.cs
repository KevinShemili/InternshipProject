namespace Application.Services {
    public interface ITokenService {
        Task<string> GenerateVerificationTokenAsync();
        Task<string> GeneratePasswordTokenAsync();
        Task<string> GenerateRefreshTokenAsync();
    }
}
