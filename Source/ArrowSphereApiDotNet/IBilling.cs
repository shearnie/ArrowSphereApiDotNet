using ArrowSphereApiDotNet.Models.Billing;
using System;

namespace ArrowSphereApiDotNet
{
    public interface IBilling
    {
        Task<GetBillingReportResponse> GetReport(GetBillingReportRequest request);
    }
}
