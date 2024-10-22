using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
	public record Filter(
        string Name,
        IEnumerable<FilterValue> Values)
    {
        public Filter() : this(string.Empty, new List<FilterValue>())
        {
        }
    }
}
