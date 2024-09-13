using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public class CreateOrderRequest
    {
        [JsonProperty(PropertyName = "scheduledDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ScheduledDate { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public CreateOrderCustomer Customer { get; set; } = new();

        [JsonProperty(PropertyName = "products")]
        public IEnumerable<CreateOrderProduct> Products { get; set; } = new List<CreateOrderProduct>();

        [JsonProperty(PropertyName = "extraInformation", NullValueHandling = NullValueHandling.Ignore)]
        public CreateOrderExtraInformation? ExtraInformation { get; set; } = null;

        [JsonProperty(PropertyName = "organizationUnitRef", NullValueHandling = NullValueHandling.Ignore)]
        public string? OrganizationUnitRef { get; set; }
    }
}
