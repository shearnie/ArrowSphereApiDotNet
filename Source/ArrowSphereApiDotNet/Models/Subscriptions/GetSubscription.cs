using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Subscriptions
{
    public record GetSubscription(
        int Status,
        SubscriptionData Data)
    {
        public GetSubscription() : this(default, new SubscriptionData())
        {
        }
    }
}
