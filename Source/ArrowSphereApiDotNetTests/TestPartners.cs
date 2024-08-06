using ArrowSphereApiDotNet;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArrowSphereApiDotNetTests
{
	public class TestPartners
    {
		private ServiceProvider _services;
		private ArrowClient _client;
		
		[SetUp]
		public async Task SetUp()
		{
			var services = new ServiceCollection();

            var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .Build();
            services.AddSingleton<IConfiguration>(config);

            _services = services
                .AddArrow(config.GetValue<string>("Arrow:ApiKey"))
                .BuildServiceProvider();

            _client = _services.GetService<ArrowClient>();
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