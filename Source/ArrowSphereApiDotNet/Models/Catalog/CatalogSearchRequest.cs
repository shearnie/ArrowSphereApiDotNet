using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
	public class CatalogSearchRequest
	{
		[JsonProperty(PropertyName = "keywords", NullValueHandling = NullValueHandling.Ignore)]
		public string? Keywords { get; set; }

		[JsonProperty(PropertyName = "filters", NullValueHandling = NullValueHandling.Ignore)]
		public CatalogSearchRequestFilters? Filters { get; set; }

		[JsonProperty(PropertyName = "sort", NullValueHandling = NullValueHandling.Ignore)]
		public Sort? Sort { get; set; }

		[JsonProperty(PropertyName = "aggregatorfilter", NullValueHandling = NullValueHandling.Ignore)]
		public IEnumerable<string>? AggregatorFilter { get; set; }

		[JsonProperty(PropertyName = "highlight", NullValueHandling = NullValueHandling.Ignore)]
		public bool? HighLight { get; set; }
	}
}
