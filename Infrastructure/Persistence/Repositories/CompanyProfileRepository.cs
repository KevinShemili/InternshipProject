using Application.Persistance;
using Domain.Entities;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories.Common;

namespace Infrastructure.Persistence.Repositories {
    public class CompanyProfileRepository : BaseRepository<CompanyProfile>, ICompanyProfileRepository {
        public CompanyProfileRepository(DatabaseContext databaseContext) : base(databaseContext) {
        }

        public async Task UpdateAsync(Guid id, CompanyProfile companyProfile) {
            var entity = await base.GetByIdAsync(id);
            entity.Country = companyProfile.Country;
            entity.Currency = companyProfile.Currency;
            entity.Exchange = companyProfile.Exchange;
            entity.IPO = companyProfile.IPO;
            entity.MarketCapitalization = companyProfile.MarketCapitalization;
            entity.Name = companyProfile.Name;
            entity.Phone = companyProfile.Phone;
            entity.ShareOutstanding = companyProfile.ShareOutstanding;
            entity.Ticker = companyProfile.Ticker;
            entity.WebUrl = companyProfile.WebUrl;
            entity.Logo = companyProfile.Logo;
            entity.FinnhubIndustry = companyProfile.FinnhubIndustry;
        }
    }
}
