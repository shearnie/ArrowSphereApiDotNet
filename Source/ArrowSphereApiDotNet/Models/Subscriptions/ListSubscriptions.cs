using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Subscriptions
{
    public record ListSubscriptions(
        int Status,
        IEnumerable<SubscriptionData> Data)
    {
        public ListSubscriptions() : this(default, new List<SubscriptionData>())
        {
        }
    }
}
