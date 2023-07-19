using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class UserVerificationAndResetRepository : BaseRepository<UserVerificationAndReset>, IUserVerificationAndResetRepository {
        public UserVerificationAndResetRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> ContainsEmail(string email) {
            var entity = await _databaseContext.UserVerificationAndReset
                .Where(x => x.UserEmail == email)
                .FirstOrDefaultAsync();

            if (entity is null)
                return false;
            return true;
        }

        public async Task<bool> ContainsVerificationToken(string token) {
            var entity = await _databaseContext.UserVerificationAndReset
                .Where(x => x.EmailVerificationToken == token)
                .FirstOrDefaultAsync();

            if (entity is null)
                return false;
            return true;
        }

        public async Task<UserVerificationAndReset> GetByEmailAsync(string email) {
            var entity = await _databaseContext.UserVerificationAndReset
                .Where(x => x.UserEmail == email)
                .FirstOrDefaultAsync();

            if (entity is null)
                return null;

            return entity;
        }

        public async Task<bool?> UpdateVerificationTokens(string email, string verificationToken, DateTime tokenExpiry) {
            var entity = await GetByEmailAsync(email);

            if (entity is null)
                return null;

            entity.EmailVerificationToken = verificationToken;
            entity.EmailVerificationTokenExpiry = tokenExpiry;
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
