using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class UserVerificationAndResetRepository : BaseRepository<UserVerificationAndReset>, IUserVerificationAndResetRepository {
        public UserVerificationAndResetRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<UserVerificationAndReset> GetByEmailAsync(string email) {
            var entity = await _databaseContext.UserVerificationAndReset
                .Where(x => x.UserEmail == email)
                .FirstOrDefaultAsync();

            if (entity is null)
                return null;

            return entity;
        }
    }
}
