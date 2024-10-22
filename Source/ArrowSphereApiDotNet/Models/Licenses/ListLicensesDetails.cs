using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record ListLicensesDetails(
        IEnumerable<ListLicensesDetailsLicense> Licenses)
    {
        public ListLicensesDetails() : this(new List<ListLicensesDetailsLicense>())
        {
        }
    }
}
