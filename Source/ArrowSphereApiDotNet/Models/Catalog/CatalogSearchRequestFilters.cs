using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
	public class CatalogSearchRequestFilters
	{
		[JsonProperty(PropertyName = "vendor", NullValueHandling = NullValueHandling.Ignore)]
		public string? Vendor { get; set; }

		[JsonProperty(PropertyName = "is_addon", NullValueHandling = NullValueHandling.Ignore)]
		public bool? Is_Addon { get; set; }

		[JsonProperty(PropertyName = "weight_forced", NullValueHandling = NullValueHandling.Ignore)]
		public int? Weight_Forced { get; set; }
	}
}
