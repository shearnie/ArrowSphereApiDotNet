using ArrowSphereApiDotNet.Models.Catalog;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ArrowSphereApiDotNet
{
    public class Catalog
	{
        private readonly ArrowClient _client;

        public Catalog(ArrowClient arrowClient)
        {
            _client = arrowClient;
        }

        public async Task<CatalogSearchResponse> Search(CatalogSearchRequest request, int? page = null, int? perPage = null, string? searchBefore = null, string? searchAfter = null)
		{
			if (page.HasValue)
			{
				searchBefore = null;
				searchAfter = null;
			}

			var parameters = HttpUtility.ParseQueryString(string.Empty);
            if (page != null) parameters["page"] = page.ToString();
			if (perPage != null) parameters["per_page"] = perPage.ToString();
			if (searchBefore != null) parameters["search_before"] = searchBefore;
			if (searchAfter != null) parameters["search_after"] = searchAfter;

			var query = "catalog/find" + (parameters.Count > 0 ? $"?{parameters.ToString()}" : "");

			return await _client.PostAsync<CatalogSearchResponse>(query, JsonConvert.SerializeObject(request));
        }
    }
}
