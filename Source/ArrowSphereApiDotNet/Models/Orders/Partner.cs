﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record Partner(
        string CompanyName,
        PartnerContact Contact)
    {
        public Partner() : this(string.Empty, new PartnerContact())
        {
        }
    }
}
