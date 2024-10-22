using ArrowSphereApiDotNet.Models.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Impl
{
    public class Billing : IBilling
    {
        private readonly ArrowClient _client;

        public Billing(ArrowClient arrowClient)
        {
            _client = arrowClient;
        }

        public async Task<GetBillingReportResponse> GetReport(GetBillingReportRequest request)
        {
            var rs = await _client.PostAsync<TempGetBillingReportResponse>("billing/erp/exports/sync", JsonHelper.SerializeLowerCamel(request));

            var data = new List<List<string>>();
            foreach (var d in rs.Data.Values)
            {
                var row = new List<string>();
                foreach (var i in d)
                {
                    row.Add(Convert.ToString(i));
                }
                data.Add(row);
            }

            return new GetBillingReportResponse(rs.Code, new GetBillingReportResponseData(rs.Data.Headers, data), rs.Pagination);
        }
    }
}
