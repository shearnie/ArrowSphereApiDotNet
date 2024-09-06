using ArrowSphereApiDotNet;
using ArrowSphereApiDotNet.Models.Billing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNetTests
{
    public class TestBilling
    {
        private ServiceProvider _services;
        private ArrowClient _client;

        [SetUp]
        public async Task SetUp()
        {
            _services = Helpers.SetUpServiceProvider();
            _client = _services.GetService<ArrowClient>();
        }

        [TearDown]
        public void TearDown()
        {
            _services.Dispose();
        }

        [Test]
        public async Task GetReport()
        {
            var client = _client.GetBillingClient();

            var rs = await client.GetReport(new GetBillingReportRequest()
            {
                Page = 1,
                ExportTypeReference = "E1-2-fabb9ae827272d7cc83a42554c3435a8",
                Filters = new Filters()
                {
                    ReportPeriod = new FiltersReportPeriod()
                    {
                        From = "2024-07",
                        To = "2025-01",
                    }
                }
            });

            Assert.That(rs.Data.Headers.Any(), Is.True);
        }
    }
}