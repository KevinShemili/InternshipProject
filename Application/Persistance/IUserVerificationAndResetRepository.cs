using Application.Persistance.Common;
using Domain.Entities;

namespace Application.Persistance {
    public interface IUserVerificationAndResetRepository : IBaseRepository<UserVerificationAndReset> {
        public Task<UserVerificationAndReset> GetByEmailAsync(string email);
    }
}
