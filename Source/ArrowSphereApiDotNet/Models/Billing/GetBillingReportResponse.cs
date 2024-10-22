using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Billing
{
    public record GetBillingReportResponse(
        int Code,
        GetBillingReportResponseData Data,
        Pagination Pagination)
    {
        public GetBillingReportResponse() : this(default, new GetBillingReportResponseData(), new Pagination())
        {
        }
    }
}
