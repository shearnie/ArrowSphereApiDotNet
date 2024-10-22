using ArrowSphereApiDotNet.Models.Billing;
using System;

namespace ArrowSphereApiDotNet.Mocks
{
    public class MockBilling : IBilling
    {
        private readonly MockData _testData;

        public MockBilling(MockData testData)
        {
            _testData = testData;
        }

        public async Task<GetBillingReportResponse> GetReport(GetBillingReportRequest request)
        {
            return await Task.FromResult(_testData.BillingReports);
        }
    }
}
