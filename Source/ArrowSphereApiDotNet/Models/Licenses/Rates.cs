using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record Rates(
        decimal Rate,
        string Type,
        DateTime LastUpdate)
    {
        public Rates() : this(default, string.Empty, default)
        {
        }
    }
}
