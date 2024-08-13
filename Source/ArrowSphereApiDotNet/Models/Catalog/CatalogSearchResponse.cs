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
    }
}
