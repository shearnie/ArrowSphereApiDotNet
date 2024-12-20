﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record CancelOrderResponseData(
        string Message)
    {
        public CancelOrderResponseData() : this(string.Empty)
        {
        }
    }
}
