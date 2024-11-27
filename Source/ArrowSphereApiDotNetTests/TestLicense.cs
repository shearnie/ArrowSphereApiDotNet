using ArrowSphereApiDotNet;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ArrowSphereApiDotNetTests
{
    public class TestLicense
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
        public async Task ListLicenses()
        {
            var client = _client.GetLicenseClient();

            var rs = await client.ListLicenses(1, 10);

            Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(rs.Data.Licenses.Any(), Is.True);

            var searchAfter = rs.Pagination.Next ?? "";
            if (!string.IsNullOrEmpty(searchAfter))
            {
                searchAfter = searchAfter.Substring(searchAfter.IndexOf("search_after="));
                searchAfter = searchAfter.Replace("search_after=", "");
            }

            while (!string.IsNullOrEmpty(searchAfter))
            {
                rs = await client.ListLicenses(null, 10, null, searchAfter);

                Assert.That(rs.Status, Is.EqualTo(200));

                searchAfter = rs.Pagination.Next ?? "";
                if (!string.IsNullOrEmpty(searchAfter))
                {
                    searchAfter = searchAfter.Substring(searchAfter.IndexOf("search_after="));
                    searchAfter = searchAfter.Replace("search_after=", "");
                }
            }
        }

        [Test]
        public async Task LicenseDetails()
        {
            var client = _client.GetLicenseClient();

            var list = await client.ListLicenses();

            var licenseId = list.Data.Licenses.First().License_Id;
            var rs = await client.LicenseDetails(licenseId);

            Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(rs.Data.License.License_Id, Is.EqualTo(licenseId));
		}


		[Test]
		public async Task LicenseUpdates()
		{
			var client = _client.GetLicenseClient();

			var list = await client.ListLicenses();

			var licenseId = list.Data.Licenses.First().License_Id;

			var updateSeats = await client.UpdateLicenseSeats(licenseId, new ArrowSphereApiDotNet.Models.Licenses.UpdateLicenseSeatsRequest() { Seats = 2 });
			Assert.That(updateSeats.Status, Is.EqualTo(204));

			var cancelRs = await client.CancelLicense(licenseId, new ArrowSphereApiDotNet.Models.Licenses.CancelLicenseRequest());
			Assert.That(cancelRs.Status, Is.EqualTo(204));
		}
	}
}