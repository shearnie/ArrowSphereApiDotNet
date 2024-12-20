﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record Subscription(
        string Reference,
        string Link)
    {
        public Subscription() : this(string.Empty, string.Empty)
        {
        }
    }
}
