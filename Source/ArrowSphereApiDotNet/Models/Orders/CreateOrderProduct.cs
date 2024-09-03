using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public class CreateOrderProduct
    {
        public string Sku { get; set; } = string.Empty;
        public string ArrowSpherePriceBandSku { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public CreateOrderSubscription Subscription { get; set; } = new();
        public string ParentLicenseId { get; set; } = string.Empty;
        public string ParentSku { get; set; } = string.Empty;
        public string Periodicity { get; set; } = string.Empty;
        public string Term { get; set; } = string.Empty;
        public bool AutoRenew { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public string VendorReferenceId { get; set; } = string.Empty;
        public string ParentVendorReferenceId { get; set; } = string.Empty;
        public string FriendlyName { get; set; } = string.Empty;
        public string Comment1 { get; set; } = string.Empty;
        public string Comment2 { get; set; } = string.Empty;
        public decimal Discount { get; set; }
        public decimal Uplift { get; set; }
        public string PromotionId { get; set; } = string.Empty;
        public string CoterminosityDate { get; set; } = string.Empty;
        public string CoterminositySubscriptionRef { get; set; } = string.Empty;
    }
}
