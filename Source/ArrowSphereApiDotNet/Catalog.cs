using ArrowSphereApiDotNet.Models.Catalog;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet
{
    public class Catalog
	{
        private readonly ArrowClient _client;

        public Catalog(ArrowClient arrowClient)
        {
            _client = arrowClient;
        }

        public async Task<CatalogSearchResponse> Search(CatalogSearchRequest request)
        {
            return await _client.PostAsync<CatalogSearchResponse>("catalog/find", JsonConvert.SerializeObject(request));
        }
    }
}
