﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Billing
{
    public record GetBillingReportResponseData(
        IEnumerable<string> Headers,
        IEnumerable<IEnumerable<dynamic>> Values)
    {
    }
}
