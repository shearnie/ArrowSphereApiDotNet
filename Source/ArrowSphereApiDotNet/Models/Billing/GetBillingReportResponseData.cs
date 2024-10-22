using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Billing
{
    public record GetBillingReportResponseData(
        IEnumerable<string> Headers,
        IEnumerable<IEnumerable<string>> Values)
    {
        public GetBillingReportResponseData() : this(new List<string>(), new List<List<string>>())
        {
        }
    }
}
