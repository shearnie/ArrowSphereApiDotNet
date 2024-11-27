using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
	public record UpdateLicenseSeatsResponse(
		int Status,
		string Error)
	{
		public UpdateLicenseSeatsResponse() : this(default, string.Empty)
		{
		}
	}
}
