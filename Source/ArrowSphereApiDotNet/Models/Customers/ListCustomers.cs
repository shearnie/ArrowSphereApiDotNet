﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Customers
{
    public record ListCustomers(
        int Status,
        ListCustomersData Data,
        Pagination Pagination)
    {
        public ListCustomers() : this(default, new ListCustomersData(), new Pagination())
        {
        }
    }
}
