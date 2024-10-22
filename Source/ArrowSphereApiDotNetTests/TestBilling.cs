using ArrowSphereApiDotNet;
using ArrowSphereApiDotNet.Models.Billing;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;

namespace ArrowSphereApiDotNetTests
{
    public class TestBilling
    {
        private ServiceProvider _services;
        private IArrowClient _client;

        [SetUp]
        public async Task SetUp()
        {
            _services = Helpers.SetUpServiceProvider();
            _client = _services.GetService<IArrowClient>();
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

            var json = JsonConvert.SerializeObject(rs);

            Assert.That(rs.Code, Is.EqualTo(200));
            Assert.That(rs.Data.Headers.Any(), Is.True);
            Assert.That(rs.Data.Values.Any(), Is.True);
            Assert.That(rs.Data.Values.First().Count(), Is.EqualTo(rs.Data.Headers.Count()));
            Assert.That(rs.Data.Values.First().First(), Is.Not.EqualTo(string.Empty));
        }
    }
}