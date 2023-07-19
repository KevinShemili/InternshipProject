using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IUserVerificationAndResetRepository : IBaseRepository<UserVerificationAndReset> {
        public Task<UserVerificationAndReset> GetByEmailAsync(string email);
        public Task<bool> ContainsEmailAsync(string email);
        public Task<bool?> UpdateVerificationTokenAsync(string email, string verificationToken, DateTime tokenExpiry);
        public Task<bool> ContainsVerificationTokenAsync(string token);
        public Task<bool?> SetPasswordTokenAsync(string email, string passwordToken, DateTime tokenExpiry);
        public Task<bool> ContainsPasswordTokenAsync(string token);

    }
}
