using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories {
    public class CompanyTypeRepository : BaseRepository<CompanyType>, ICompanyTypeRepository {
        public CompanyTypeRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task<bool> ContainsAsync(string type) {
            var entity = await _databaseContext.CompanyTypes
                .Where(x => x.Type == type)
                .FirstOrDefaultAsync();

            if (entity is null)
                return false;
            return true;
        }

        public async Task<CompanyType> GetByNameAsync(string name) {
            var entity = await _databaseContext.CompanyTypes
                .Where(x => x.Type == name)
                .FirstOrDefaultAsync();

            if (entity is null)
                return null;
            return entity;
        }
    }
}
