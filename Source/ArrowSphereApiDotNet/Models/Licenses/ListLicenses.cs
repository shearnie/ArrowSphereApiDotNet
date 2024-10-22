using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record ListLicenses(
        int Status,
        ListLicensesDetails Data,
        Pagination Pagination)
    {
        public ListLicenses() : this(default, new ListLicensesDetails(), new Pagination())
        {
        }
    }
}
