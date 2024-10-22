using ArrowSphereApiDotNet.Models.Subscriptions;
using System;

namespace ArrowSphereApiDotNet
{
    public interface ISubscriptions
    {
        Task<ListSubscriptions> ListSubscriptions();
        Task<GetSubscription> GetSubscription(string reference);
    }
}
