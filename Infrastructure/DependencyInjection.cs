using Application.Interfaces.Authentication;
using Application.Persistance;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Services.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;

namespace Infrastructure {
    public static class DependencyInjection {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration) {
            AddScopes(services);
            AddDatabaseConnection(services, configuration);
            AddJwtSettings(services, configuration);
            return services;
        }

        private static void AddScopes(IServiceCollection services) {
            services.AddScoped<IJwtToken, JwtToken>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        private static void AddDatabaseConnection(IServiceCollection services, IConfiguration configuration) {
            var connString = configuration.GetConnectionString("DbConnection");
            services.AddDbContext<DatabaseContext>(options => 
                options.UseSqlServer(connString, b => b.MigrationsAssembly("Infrastructure")));
        }

        // object to model the section defined in appsettings.json
        private static void AddJwtSettings(IServiceCollection services, IConfiguration configuration) {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        }
    }
}
