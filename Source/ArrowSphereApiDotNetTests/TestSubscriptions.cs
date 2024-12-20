﻿using ArrowSphereApiDotNet;
using ArrowSphereApiDotNet.Models.Subscriptions;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ArrowSphereApiDotNetTests
{
    public class TestSubscriptions
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
		public async Task ListSubscriptions()
		{
			var client = _client.GetSubscriptionsClient();

			var rs = await client.ListSubscriptions();

			Assert.That(rs.Status, Is.EqualTo(200));
			Assert.That(string.IsNullOrEmpty(rs.Data.First().Name), Is.False);
		}

		[Test]
		public async Task GetSubscription()
		{
			var client = _client.GetSubscriptionsClient();

			var list = await client.ListSubscriptions();
			var rs = await client.GetSubscription(list.Data.First().Reference);

			Assert.That(rs.Status, Is.EqualTo(200));
            Assert.That(rs.Data.Reference, Is.EqualTo(list.Data.First().Reference));
            Assert.That(string.IsNullOrEmpty(rs.Data.Name), Is.False);
        }
    }
}