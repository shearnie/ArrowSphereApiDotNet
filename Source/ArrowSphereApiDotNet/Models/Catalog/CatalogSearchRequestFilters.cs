using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
	public class CatalogSearchRequestFilters
	{
		public string Vendor { get; set; } = string.Empty;
		public bool Is_Addon { get; set; }
		public int Weight_Forced { get; set; }
	}
}
