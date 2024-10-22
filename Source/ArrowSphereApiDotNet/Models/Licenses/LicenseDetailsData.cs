using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record LicenseDetailsData(
        LicenseDetailsLicense License)
    {
        public LicenseDetailsData() : this(new LicenseDetailsLicense())
        {
        }
    }
}
