using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet
{
    public static class ArrowServicesExtension
    {
        public static IServiceCollection AddArrow(this IServiceCollection services, string apiKey, string? apiBasePath = null)
        {
            services.AddHttpClient();
            services.AddScoped(i => new ArrowConfig(apiKey, apiBasePath ?? "https://xsp.arrow.com/index.php/api/"));
            services.AddScoped<ArrowClient>();
            return services;
        }
    }
}
