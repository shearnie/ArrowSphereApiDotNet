using ArrowSphereApiDotNet.Models.Billing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet
{
    public class Billing
    {
        private readonly ArrowClient _client;

        public Billing(ArrowClient arrowClient)
        {
            _client = arrowClient;
        }

        public async Task<GetBillingReportResponse> GetReport(GetBillingReportRequest request)
        {
            return await _client.PostAsync<GetBillingReportResponse>("billing/erp/exports/sync", JsonHelper.SerializeLowerCamel(request));
        }
    }
}
