using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record LicenseDetails(
        int Status,
        LicenseDetailsData Data)
    {
        public LicenseDetails() : this(default, new LicenseDetailsData())
        {
        }
    }
}
