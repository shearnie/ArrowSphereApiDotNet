﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record PartnerContact(
        string Email,
        string FirstName,
        string LastName)
    {
        public PartnerContact() : this(string.Empty, string.Empty, string.Empty)
        {
        }
    }
}
