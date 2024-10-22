using System;

namespace ArrowSphereApiDotNet.Mocks
{
    public class MockArrowClient : IArrowClient
    {
        private readonly MockData _testData;

        public MockArrowClient(MockData testData)
        {
            _testData = testData;
        }

        public IPartners GetPartnersClient()
        {
            return new MockPartners(_testData);
        }

        public ICustomers GetCustomersClient()
        {
            return new MockCustomers(_testData);
        }

		public ICatalog GetCatalogClient()
		{
			return new MockCatalog(_testData);
		}

		public ISubscriptions GetSubscriptionsClient()
		{
			return new MockSubscriptions(_testData);
        }

        public IOrders GetOrdersClient()
        {
            return new MockOrders(_testData);
        }

        public IBilling GetBillingClient()
        {
            return new MockBilling(_testData);
        }

        public ILicenses GetLicenseClient()
        {
            return new MockLicenses(_testData);
        }
    }
}
