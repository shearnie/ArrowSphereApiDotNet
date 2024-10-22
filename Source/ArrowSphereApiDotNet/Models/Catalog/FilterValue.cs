using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
	public record FilterValue(
        string Value,
        int Count)
    {
        public FilterValue() : this(string.Empty, default)
        {
        }
    }
}
