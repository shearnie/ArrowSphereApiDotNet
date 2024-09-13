using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public class CreateOrderProduct
    {
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "arrowSpherePriceBandSku", NullValueHandling = NullValueHandling.Ignore)]
        public string? ArrowSpherePriceBandSku { get; set; }

        [JsonProperty(PropertyName = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "subscription")]
        public CreateOrderSubscription Subscription { get; set; } = new();

        [JsonProperty(PropertyName = "parentLicenseId", NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentLicenseId { get; set; }

        [JsonProperty(PropertyName = "parentSku", NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentSku { get; set; }

        [JsonProperty(PropertyName = "periodicity")]
        public string Periodicity { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "term")]
        public string Term { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "autoRenew")]
        public bool AutoRenew { get; set; }

        [JsonProperty(PropertyName = "effectiveStartDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EffectiveStartDate { get; set; }

        [JsonProperty(PropertyName = "effectiveEndDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EffectiveEndDate { get; set; }

        [JsonProperty(PropertyName = "vendorReferenceId", NullValueHandling = NullValueHandling.Ignore)]
        public string? VendorReferenceId { get; set; }

        [JsonProperty(PropertyName = "parentVendorReferenceId", NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentVendorReferenceId { get; set; }

        [JsonProperty(PropertyName = "friendlyName", NullValueHandling = NullValueHandling.Ignore)]
        public string? FriendlyName { get; set; }

        [JsonProperty(PropertyName = "comment1", NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment1 { get; set; }

        [JsonProperty(PropertyName = "comment2", NullValueHandling = NullValueHandling.Ignore)]
        public string? Comment2 { get; set; }

        [JsonProperty(PropertyName = "discount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Discount { get; set; } = null;

        [JsonProperty(PropertyName = "uplift", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Uplift { get; set; } = null;

        [JsonProperty(PropertyName = "coterminosityDate", NullValueHandling = NullValueHandling.Ignore)]
        public string? CoterminosityDate { get; set; }

        [JsonProperty(PropertyName = "coterminositySubscriptionRef", NullValueHandling = NullValueHandling.Ignore)]
        public string? CoterminositySubscriptionRef { get; set; }
    }
}
