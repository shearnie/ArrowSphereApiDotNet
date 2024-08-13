using ArrowSphereApiDotNet;
using Microsoft.Extensions.DependencyInjection;

namespace ArrowSphereApiDotNetTests
{
	public class TestCustomers
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
		public async Task ListCustomers()
        {
			var client = _client.GetCustomersClient();

			var rs = await client.ListCustomers();

            Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(string.IsNullOrEmpty(rs.Data.Customers.First().Reference), Is.False);
            Assert.That(string.IsNullOrEmpty(rs.Data.Customers.First().CompanyName), Is.False);
        }

        [Test]
        public async Task CustomerDetails()
        {
            var client = _client.GetCustomersClient();

            var list = await client.ListCustomers();

            var reference = list.Data.Customers.First().Reference;
            var name = list.Data.Customers.First().CompanyName;
            var rs = await client.CustomerDetails(reference);

            Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(rs.Data.Customers.First().Reference, Is.EqualTo(reference));
            Assert.That(rs.Data.Customers.First().CompanyName, Is.EqualTo(name));
        }
    }
}