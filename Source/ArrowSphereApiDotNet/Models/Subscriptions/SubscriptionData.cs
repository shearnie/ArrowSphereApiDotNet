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
        DateTime DateValidation,
        DateTime DateEnd,
        string Level,
		SubscriptionDetail Details,
		dynamic ExtraInformation)
    {
	}
}
