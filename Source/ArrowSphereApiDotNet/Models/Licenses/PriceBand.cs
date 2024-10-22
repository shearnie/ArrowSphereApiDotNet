using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record PriceBand(
        Billing Billing,
        SaleConstraints SaleConstraints,
        IEnumerable<Attribute> Attributes)
    {
        public PriceBand() : this(new Billing(), new SaleConstraints(), new List<Attribute>())
        {
        }
    }
}
