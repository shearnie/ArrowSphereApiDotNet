using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet
{
    public static class JsonHelper
    {
        public static string Serialize(object? value)
        {
            return JsonConvert.SerializeObject(
                value,
                new JsonSerializerSettings 
                {
                    ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
                });
        }
    }
}
