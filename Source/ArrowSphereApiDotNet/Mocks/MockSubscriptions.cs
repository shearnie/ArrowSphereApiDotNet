using ArrowSphereApiDotNet.Models.Subscriptions;
using System;

namespace ArrowSphereApiDotNet
{
    public class MockSubscriptions : ISubscriptions
    {
        private readonly MockData _testData;

        public MockSubscriptions(MockData testData)
        {
            _testData = testData;
        }

        public async Task<ListSubscriptions> ListSubscriptions()
        {
            return await Task.FromResult(_testData.Subscriptions);
        }

		public async Task<GetSubscription> GetSubscription(string reference)
        {
            return await Task.FromResult(_testData.Subscriptions.Data
                    .Where(i => i.Reference == reference)
                    .Select(i => new GetSubscription()
                    {
                        Status = 200,
                        Data = new SubscriptionData()
                        {
                            Reference = i.Reference,
                            Name = i.Name,
                            Status = i.Status,
                            DateDemand = i.DateDemand,
                            DateValidation = i.DateValidation,
                            DateEnd = i.DateEnd,
                            Level = i.Level,
                            Details = i.Details,
                            ExtraInformation = i.ExtraInformation,
                        }
                    })
                    .First());
        }
    }
}
