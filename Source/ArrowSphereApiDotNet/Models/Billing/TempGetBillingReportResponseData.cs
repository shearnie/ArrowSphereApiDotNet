using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Billing
{
    internal record TempGetBillingReportResponseData(
        IEnumerable<string> Headers,
        IEnumerable<IEnumerable<dynamic>> Values)
    {
        public TempGetBillingReportResponseData() : this(new List<string>(), new List<List<dynamic>>())
        {
        }
    }
}
