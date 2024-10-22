using ArrowSphereApiDotNet.Models.Catalog;
using System;

namespace ArrowSphereApiDotNet
{
    public interface ICatalog
    {
        Task<CatalogSearchResponse> Search(CatalogSearchRequest request, int? page = null, int? perPage = null, string? searchBefore = null, string? searchAfter = null);
    }
}
