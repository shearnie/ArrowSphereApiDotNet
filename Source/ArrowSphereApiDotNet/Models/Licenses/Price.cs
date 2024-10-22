using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record Price(
        string PriceBandArrowsphereSku,
        string Currency,
        PriceDetail Unit,
        PriceDetail Total)
    {
        public Price() : this(string.Empty, string.Empty, new PriceDetail(), new PriceDetail())
        {
        }
    }
}
