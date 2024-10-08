﻿using ArrowSphereApiDotNet;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNetTests
{
    public class TestLicense
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
        public async Task ListLicenses()
        {
            var client = _client.GetLicenseClient();

            var rs = await client.ListLicenses();

            Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(rs.Data.Licenses.Any(), Is.True);
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
    }
}