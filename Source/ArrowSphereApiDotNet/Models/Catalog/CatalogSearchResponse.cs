using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
    public record CatalogSearchResponse(
        IEnumerable<Product> Products,
        IEnumerable<Filter> Filters,
        Pagination Pagination)
    {
        public CatalogSearchResponse() : this(new List<Product>(), new List<Filter>(), new Pagination())
        {
        }
    }
}
