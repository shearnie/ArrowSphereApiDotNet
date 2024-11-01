﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record CreateOrderResponseData(
        string Reference,
        string Link)
    {
        public CreateOrderResponseData() : this(string.Empty, string.Empty)
        {
        }
    }
}
