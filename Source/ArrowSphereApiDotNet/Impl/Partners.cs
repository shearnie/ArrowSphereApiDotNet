using ArrowSphereApiDotNet.Models.Partners;
using System;

namespace ArrowSphereApiDotNet.Impl
{
    public class Partners : IPartners
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
