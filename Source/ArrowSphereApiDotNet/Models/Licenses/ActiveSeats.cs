﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record ActiveSeats(
        int? Number,
        DateTime? LastUpdate)
    {
        public ActiveSeats() : this(null, null)
        {
        }
    }
}
