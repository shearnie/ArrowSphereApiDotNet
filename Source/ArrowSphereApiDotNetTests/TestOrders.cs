using ArrowSphereApiDotNet;
using ArrowSphereApiDotNet.Models.Orders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNetTests
{
    public class TestOrders
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
    }
}