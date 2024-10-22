using ArrowSphereApiDotNet;
using ArrowSphereApiDotNet.Models.Billing;
using ArrowSphereApiDotNet.Models.Catalog;
using ArrowSphereApiDotNet.Models.Customers;
using ArrowSphereApiDotNet.Models.Licenses;
using ArrowSphereApiDotNet.Models.Orders;
using ArrowSphereApiDotNet.Models.Partners;
using ArrowSphereApiDotNet.Models.Subscriptions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;

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
                //.AddArrow(config.GetValue<string>("Arrow:ApiKey"), config.GetValue<string>("Arrow:ApiBasePath"))
                .AddArrowForTesting(TestData())
                .BuildServiceProvider();
        }

        private static MockData TestData()
        {
            var data = new MockData();

            var testDataPath = Path.Combine(Environment.CurrentDirectory, "TestData");

            using (var r = new StreamReader(Path.Combine(testDataPath, "BillingReport.json")))
            {
                data.BillingReports = JsonConvert.DeserializeObject<GetBillingReportResponse>(r.ReadToEnd());
            }
            using (var r = new StreamReader(Path.Combine(testDataPath, "Catalog.json")))
            {
                data.Catalog = JsonConvert.DeserializeObject<CatalogSearchResponse>(r.ReadToEnd());
            }
            using (var r = new StreamReader(Path.Combine(testDataPath, "CustomerList.json")))
            {
                data.CustomerList = JsonConvert.DeserializeObject<ListCustomers>(r.ReadToEnd());
            }
            using (var r = new StreamReader(Path.Combine(testDataPath, "Licenses.json")))
            {
                data.Licenses = JsonConvert.DeserializeObject<ListLicenses>(r.ReadToEnd());
            }
            using (var r = new StreamReader(Path.Combine(testDataPath, "Orders.json")))
            {
                data.Orders = JsonConvert.DeserializeObject<ListOrders>(r.ReadToEnd());
            }
            using (var r = new StreamReader(Path.Combine(testDataPath, "WhoAmI.json")))
            {
                data.WhoAmI = JsonConvert.DeserializeObject<WhoAmI>(r.ReadToEnd());
            }
            using (var r = new StreamReader(Path.Combine(testDataPath, "Subscriptions.json")))
            {
                data.Subscriptions = JsonConvert.DeserializeObject<ListSubscriptions>(r.ReadToEnd());
            }

            return data;
        }
    }
}
