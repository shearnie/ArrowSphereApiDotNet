using ArrowSphereApiDotNet.Models.Licenses;
using Newtonsoft.Json;
using System;
using System.Web;

namespace ArrowSphereApiDotNet.Impl
{
    public class Licenses : ILicenses
    {
        private readonly ArrowClient _client;

        public Licenses(ArrowClient arrowClient)
        {
            _client = arrowClient;
        }

        public async Task<ListLicenses> ListLicenses(int? page = null, int? perPage = null, string? searchBefore = null, string? searchAfter = null)
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

            var query = "v2/licenses" + (parameters.Count > 0 ? $"?{parameters.ToString()}" : "");

            return await _client.GetAsync<ListLicenses>(query);
        }

        public async Task<LicenseDetails> LicenseDetails(string licenseReference)
        {
            return await _client.GetAsync<LicenseDetails>($"licenses/{licenseReference}");
        }

        public async Task<UpdateLicenseResponse> UpdateLicense(string licenseReference, UpdateLicenseRequest request)
        {
            return await _client.PatchAsync<UpdateLicenseResponse>($"licenses/{licenseReference}", JsonConvert.SerializeObject(request));
        }
    }
}
