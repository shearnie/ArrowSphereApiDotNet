using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public class CreateOrderExtraInformation
    {
        [JsonProperty(PropertyName = "programs", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic? Programs { get; set; }
    }
}
