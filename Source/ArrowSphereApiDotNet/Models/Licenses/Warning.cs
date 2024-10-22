using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record Warning(
        string Key,
        string Message)
    {
        public Warning() : this(string.Empty, string.Empty)
        {
        }
    }
}
