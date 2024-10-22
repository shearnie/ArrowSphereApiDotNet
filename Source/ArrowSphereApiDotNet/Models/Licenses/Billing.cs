﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record Billing(
        string Type)
    {
        public Billing() : this(string.Empty)
        {
        }
    }
}
