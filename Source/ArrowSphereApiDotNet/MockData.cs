using ArrowSphereApiDotNet.Models.Billing;
using ArrowSphereApiDotNet.Models.Catalog;
using ArrowSphereApiDotNet.Models.Customers;
using ArrowSphereApiDotNet.Models.Licenses;
using ArrowSphereApiDotNet.Models.Orders;
using ArrowSphereApiDotNet.Models.Partners;
using ArrowSphereApiDotNet.Models.Subscriptions;

namespace ArrowSphereApiDotNet
{
    public class MockData
    {
        public GetBillingReportResponse BillingReports { get; set; } = new();
        public CatalogSearchResponse Catalog { get; set; } = new CatalogSearchResponse();
        public ListCustomers CustomerList { get; set; } = new();
        public ListLicenses Licenses { get; set; } = new();
        public ListOrders Orders { get; set; } = new();
        public WhoAmI WhoAmI { get; set; } = new();
        public ListSubscriptions Subscriptions { get; set; } = new();
    }
}
