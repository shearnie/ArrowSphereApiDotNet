using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Billing
{
    internal record TempGetBillingReportResponse(
        int Code,
        TempGetBillingReportResponseData Data,
        Pagination Pagination)
    {
        public TempGetBillingReportResponse() : this(default, new TempGetBillingReportResponseData(), new Pagination())
        {
        }
    }
}
