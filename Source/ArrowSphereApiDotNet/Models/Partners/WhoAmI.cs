using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Partners
{
    public record WhoAmI(
        int Status,
        Company Data)
    {
        public WhoAmI() : this(default, new Company())
        {
        }
    }
}
