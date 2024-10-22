using ArrowSphereApiDotNet.Models.Subscriptions;
using System;

namespace ArrowSphereApiDotNet.Impl
{
    public class Subscriptions : ISubscriptions
    {
        private readonly ArrowClient _client;

        public Subscriptions(ArrowClient arrowClient)
        {
            _client = arrowClient;
        }

        public async Task<ListSubscriptions> ListSubscriptions()
        {
            return await _client.GetAsync<ListSubscriptions>("subscriptions");
        }

        public async Task<GetSubscription> GetSubscription(string reference)
        {
            return await _client.GetAsync<GetSubscription>($"subscriptions/{reference}");
        }
    }
}
