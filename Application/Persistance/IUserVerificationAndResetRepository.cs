using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IUserVerificationAndResetRepository : IBaseRepository<UserVerificationAndReset> {
        public Task<UserVerificationAndReset> GetByEmailAsync(string email);
        public Task<bool> ContainsEmail(string email);
        public Task<bool?> UpdateVerificationTokens(string email, string verificationToken, DateTime tokenExpiry);
        public Task<bool> ContainsVerificationToken(string token);

    }
}
