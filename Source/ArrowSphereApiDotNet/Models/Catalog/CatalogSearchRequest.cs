using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
	public class CatalogSearchRequest
	{
		public string Keywords { get; set; } = string.Empty;
		public CatalogSearchRequestFilters Filters { get; set; } = new();
		public Sort Sort { get; set; } = new();
		public IEnumerable<string> AggregatorFilter { get; set; } = [];
		public bool HighLight { get; set; }
	}
}
