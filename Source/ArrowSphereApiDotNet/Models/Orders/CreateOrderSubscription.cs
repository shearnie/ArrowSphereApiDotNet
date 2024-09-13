using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public class CreateOrderSubscription
    {
        [JsonProperty(PropertyName = "reference")]
        public string Reference { get; set; } = string.Empty;
    }
}
