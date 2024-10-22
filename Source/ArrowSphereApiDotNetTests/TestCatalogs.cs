using ArrowSphereApiDotNet;
using ArrowSphereApiDotNet.Models.Catalog;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ArrowSphereApiDotNetTests
{
	public class TestCatalogs
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
		public async Task Find()
        {
			var client = _client.GetCatalogClient();

			var rs = await client.Search(new CatalogSearchRequest());

            Assert.That(rs.Products.Any(), Is.True);
            Assert.That(rs.Products.Count(), Is.EqualTo(rs.Pagination.Per_Page));
        }
    }
}