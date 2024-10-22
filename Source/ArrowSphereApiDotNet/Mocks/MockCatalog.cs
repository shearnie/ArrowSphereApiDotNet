using ArrowSphereApiDotNet.Models.Catalog;
using System;

namespace ArrowSphereApiDotNet.Mocks
{
    public class MockCatalog : ICatalog
    {
        private readonly MockData _testData;

        public MockCatalog(MockData testData)
        {
            _testData = testData;
        }

        public async Task<CatalogSearchResponse> Search(CatalogSearchRequest request, int? page = null, int? perPage = null, string? searchBefore = null, string? searchAfter = null)
        {
            return await Task.FromResult(_testData.Catalog);
        }
    }
}
