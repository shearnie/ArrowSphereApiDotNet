using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Subscriptions
{
    public record SubscriptionDetail(
        string Sales_Guid,
        string Admin_Guid,
        string HelpDesk_Guid,
        string MpnId,
        string TenantId,
        int IaasDiscountRate,
        string IaasDiscountRateUnit)
    {
	}
}
