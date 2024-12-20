﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record ListOrdersDetails(
        IEnumerable<Order> Orders)
    {
        public ListOrdersDetails() : this(new List<Order>())
        {
        }
    }
}
