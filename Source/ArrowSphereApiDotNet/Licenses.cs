using ArrowSphereApiDotNet.Models.Licenses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet
{
    public class Licenses
    {
		private readonly ArrowClient _client;

		public Licenses(ArrowClient arrowClient)
		{
			_client = arrowClient;
		}

        public async Task<ListLicenses> ListLicenses()
        {
            return await _client.GetAsync<ListLicenses>($"v2/licenses");
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
