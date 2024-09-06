using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Billing
{
    public class GetBillingReportRequest
    {
        public int Page { get; set; }
        public string ExportTypeReference { get; set; } = string.Empty;
        public OutputFormat OutputFormat { get; set; } = new();
        public Filters Filters { get; set; } = new();
    }
}
