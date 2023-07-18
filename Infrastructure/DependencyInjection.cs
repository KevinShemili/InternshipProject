using Application.Interfaces.Authentication;
using Application.Persistance;
using Domain.Exceptions;
using Infrastructure.Persistence.Context;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Services.Authentication.JwtTokenConfigurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Infrastructure
{
    public static class DependencyInjection {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration) {
            AddScopes(services);
            AddDatabaseConnection(services, configuration);
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            AddAuthentication(services, configuration);
            return services;
        }

        private static void AddScopes(IServiceCollection services) {
            services.AddScoped<IJwtToken, JwtToken>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
        }

        private static void AddDatabaseConnection(IServiceCollection services, IConfiguration configuration) {
            var connString = configuration.GetConnectionString("DbConnection");
            services.AddDbContext<DatabaseContext>(options => 
                options.UseSqlServer(connString, b => b.MigrationsAssembly("Infrastructure")));
        }

        private static void AddAuthentication(IServiceCollection services, IConfiguration configuration) {
            
            // object model the section defined in appsettings.json
            var JwtSettings = new JwtSettings();
            configuration.Bind(JwtSettings.SectionName, JwtSettings);
            services.AddSingleton(Options.Create(JwtSettings));

            services.AddAuthentication(opts => {
                opts.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opts.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(opts => 
                opts.TokenValidationParameters = new TokenValidationParameters {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = JwtSettings.Issuer,
                    ValidAudience = JwtSettings.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(JwtSettings.Secret))
                }
                ); 
        }
    }
}
