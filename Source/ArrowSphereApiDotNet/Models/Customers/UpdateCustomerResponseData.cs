﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Customers
{
	public record UpdateCustomerResponseData(
        IEnumerable<UpdateCustomerResponseDetail> Customers)
    {
    }
}
