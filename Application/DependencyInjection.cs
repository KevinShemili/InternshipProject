using Application.Validator;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application {
    public static class DependencyInjection {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services) {
            ConfigureAutoMapper(services);
            ConfigureMediatR(services);
            ConfigureFluentValidation(services);


            return services;
        }

        private static void ConfigureMediatR(IServiceCollection services) {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }

        private static void ConfigureFluentValidation(IServiceCollection services) {
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private static void ConfigureAutoMapper(IServiceCollection services) {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
