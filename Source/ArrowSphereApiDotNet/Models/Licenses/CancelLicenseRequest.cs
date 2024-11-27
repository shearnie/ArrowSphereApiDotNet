using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public class CancelLicenseRequest()
	{
		public ExtraInformation ExtraInformation { get; set; } = new();
    }
}
