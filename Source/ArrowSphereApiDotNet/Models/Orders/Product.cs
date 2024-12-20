﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record Product(
        string Sku,
        string Name,
        string Classification,
        Program Program,
        Identifier Identifiers,
        int Quantity,
        string Status,
        string DateStatus,
        bool IsAddon,
        bool IsTrial,
        IEnumerable<string> ArrowSubCategories,
        string DetailedStatus,
        Price Prices,
        Subscription Subscription,
        License License,
        string VendorName,
        string ProgramName)
    {
        public Product() : this(string.Empty, string.Empty, string.Empty, new Program(), new Identifier(), default, string.Empty, string.Empty, false, false, new List<string>(), string.Empty,
                                new Price(), new Subscription(), new License(), string.Empty, string.Empty)
        {
        }
    }
}
