﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record Program(
        string LegacyCode)
    {
        public Program() : this(string.Empty)
        {
        }
    }
}
