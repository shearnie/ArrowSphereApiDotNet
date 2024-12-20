﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record CancelOrderResponse(
        int Status,
        CancelOrderResponseData Data)
    {
        public CancelOrderResponse() : this(default, new CancelOrderResponseData())
        {
        }
    }
}
