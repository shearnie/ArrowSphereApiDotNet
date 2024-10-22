using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record Config(
        string Scope,
        string Name,
        string State)
    {
        public Config() : this(string.Empty, string.Empty, string.Empty)
        {
        }
    }
}
