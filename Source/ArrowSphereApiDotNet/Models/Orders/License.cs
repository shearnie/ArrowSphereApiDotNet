﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record License(
        string Reference,
        string Link)
    {
        public License() : this(string.Empty, string.Empty)
        {
        }
    }
}
