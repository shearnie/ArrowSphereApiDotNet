using ArrowSphereApiDotNet.Models.Partners;
using System;

namespace ArrowSphereApiDotNet.Mocks
{
    public class MockPartners : IPartners
    {
        private readonly MockData _testData;

        public MockPartners(MockData testData)
        {
            _testData = testData;
        }

        public async Task<WhoAmI> WhoAmI()
        {
            return await Task.FromResult(_testData.WhoAmI);
        }
    }
}
