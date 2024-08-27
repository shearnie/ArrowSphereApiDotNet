using ArrowSphereApiDotNet;
using ArrowSphereApiDotNet.Models.Customers;
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

        [Ignore("Do this manually.")]
        [Test]
        public async Task CreateCustomer()
        {
            var client = _client.GetCustomersClient();

            var create = await client.CreateCustomer(new CreateCustomerRequest()
            {
                CompanyName = "Test",
                AddressLine1 = "Anne Street",
                Zip = "4000",
                City = "Brisbane",
                CountryCode = "AU",
                ReceptionPhone = "+61 123456",
                Contact = new Contact()
                {
                    FirstName = "J",
                    LastName = "Doe",
                    Email = "test@email.com",
                    Phone = "+61 1234567",
                    Type = "Primary",
                },
            });
            Assert.That(create.Status, Is.EqualTo(200));

            var rs = await client.CustomerDetails(create.Data.Reference);

            Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(rs.Data.Customers.First().Reference, Is.EqualTo(create.Data.Reference));
        }

        [Ignore("Do this manually.")]
        [Test]
        public async Task UpdateCustomer()
        {
            var client = _client.GetCustomersClient();

            var update = await client.UpdateCustomer(new UpdateCustomerRequest()
            {
                CompanyName = "Test Changed",
                AddressLine1 = "Anne Street",
                Zip = "4000",
                City = "Brisbane",
                CountryCode = "AU",
                ReceptionPhone = "+61 123456",
                Contact = new Contact()
                {
                    FirstName = "Jon",
                    LastName = "Doe",
                    Email = "test@email.com",
                    Phone = "+61 1234567",
                    Type = "Primary",
                },
            });
            Assert.That(update.Status, Is.EqualTo(200));

            var rs = await client.CustomerDetails(update.Data.Customers.First().Reference);

            Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(rs.Data.Customers.First().Reference, Is.EqualTo(update.Data.Customers.First().Reference));
            Assert.That(rs.Data.Customers.First().CompanyName, Is.EqualTo("Test Changed"));
            Assert.That(rs.Data.Customers.First().Contact.FirstName, Is.EqualTo("Jon"));
        }
    }
}