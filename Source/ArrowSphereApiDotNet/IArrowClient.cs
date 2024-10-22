using System;

namespace ArrowSphereApiDotNet
{
    public interface IArrowClient
    {
        IPartners GetPartnersClient();
        ICustomers GetCustomersClient();
        ICatalog GetCatalogClient();
        ISubscriptions GetSubscriptionsClient();
        IOrders GetOrdersClient();
        IBilling GetBillingClient();
        ILicenses GetLicenseClient();
    }
}
