using ArrowSphereApiDotNet;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ArrowSphereApiDotNetTests
{
    public class TestOrders
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
        public async Task ListOrders()
        {
            var client = _client.GetOrdersClient();

            var rs = await client.ListOrders();

            Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(string.IsNullOrEmpty(rs.Data.Orders.First().Reference), Is.False);
            Assert.That(string.IsNullOrEmpty(rs.Data.Orders.First().Customer.Reference), Is.False);
        }

        [Test]
        public async Task OrderDetails()
        {
            var client = _client.GetOrdersClient();

            var list = await client.ListOrders();

            var reference = list.Data.Orders.First().Reference;
            var rs = await client.OrderDetails(reference);

            Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(rs.Data.Orders.First().Reference, Is.EqualTo(reference));
        }
    }
}