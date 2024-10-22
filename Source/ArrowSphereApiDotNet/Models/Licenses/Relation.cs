using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record Relation(
        string PartnerRef,
        string Type)
    {
        public Relation() : this(string.Empty, string.Empty)
        {
        }
    }
}
