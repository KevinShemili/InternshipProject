using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application {
    public static class DependencyInjection {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services) {
            AddScopes(services);

            return services;
        } 

        private static void AddScopes(IServiceCollection services) {

        }
    }
}
