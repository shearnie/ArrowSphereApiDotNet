using ArrowSphereApiDotNet;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ArrowSphereApiDotNetTests
{
	public class TestPartners
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
		public async Task WhoAmI()
        {
			var client = _client.GetPartnersClient();

			var rs = await client.WhoAmI();

            Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(string.IsNullOrEmpty(rs.Data.CompanyName), Is.False);
            Assert.That(string.IsNullOrEmpty(rs.Data.User.Login), Is.False);
        }
    }
}