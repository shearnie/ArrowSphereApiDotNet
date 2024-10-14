using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public class UpdateLicenseRequest()
    {
        public string FriendlyName { get; set; } = string.Empty;
        public int Seats { get; set; }
        public int? OrganizationUnitId { get; set; } = null;
    }
}
