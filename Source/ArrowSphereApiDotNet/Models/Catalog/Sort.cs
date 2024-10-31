using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
	public class Sort
	{
		[JsonProperty(PropertyName = "name", NullValueHandling = NullValueHandling.Ignore)]
		public string? Name { get; set; }

		[JsonProperty(PropertyName = "is_addon", NullValueHandling = NullValueHandling.Ignore)]
		public string? Is_Addon { get; set; }
	}
}
