using ArrowSphereApiDotNet.Models.Partners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet
{
    public class Partners
    {
        private readonly ArrowClient _client;

        public Partners(ArrowClient arrowClient)
        {
            _client = arrowClient;
        }

        public async Task<WhoAmI> WhoAmI()
        {
            return await _client.GetAsync<WhoAmI>("whoami");
        }
    }
}
