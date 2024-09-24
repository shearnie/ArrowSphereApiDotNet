using ArrowSphereApiDotNet;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNetTests
{
    internal class Helpers
    {
        public static ServiceProvider SetUpServiceProvider()
        {
            var services = new ServiceCollection();

            var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build();
            services.AddSingleton<IConfiguration>(config);

            return services
                .AddArrow(config.GetValue<string>("Arrow:ApiKey"), config.GetValue<string>("Arrow:ApiBasePath"))
                .BuildServiceProvider();
        }
    }
}
