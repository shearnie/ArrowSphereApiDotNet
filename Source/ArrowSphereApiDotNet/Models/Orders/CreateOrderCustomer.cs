using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public class CreateOrderCustomer
    {
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "poNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string? PoNumber { get; set; }
    }
}
