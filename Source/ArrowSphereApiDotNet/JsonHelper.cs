﻿using Newtonsoft.Json;
using System;

namespace ArrowSphereApiDotNet
{
    public static class JsonHelper
    {
        public static string SerializeLowerCamel(object? value)
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
