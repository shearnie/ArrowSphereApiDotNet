﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record SaleConstraints(
        int MinQuantity,
        int MaxQuantity)
    {
        public SaleConstraints() : this(default, default)
        {
        }
    }
}
