using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Subscriptions
{
    public record SubscriptionData(
        string Reference,
        string Name,
        string Status,
        DateTime DateDemand,
        string DateValidation,
        DateTime DateEnd,
        string Level,
		SubscriptionDetail Details,
		dynamic? ExtraInformation)
    {
        public SubscriptionData() : this(string.Empty, string.Empty, string.Empty, default, string.Empty, default, string.Empty, new SubscriptionDetail(), null)
        {
        }
    }
}
