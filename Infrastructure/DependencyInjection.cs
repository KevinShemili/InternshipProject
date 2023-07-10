using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure {
    public static class DependencyInjection {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration) {
            AddScopes(services);
            AddDatabaseConnection(services, configuration);
            return services;
        }

        private static void AddScopes(IServiceCollection services) {

        }

        private static void AddDatabaseConnection(IServiceCollection services, IConfiguration configuration) {
            var connString = configuration.GetConnectionString("DbConnection");
            services.AddDbContext<DatabaseContext>(options => 
                options.UseSqlServer(connString, b => b.MigrationsAssembly("Infrastructure")));
        }
    }
}
