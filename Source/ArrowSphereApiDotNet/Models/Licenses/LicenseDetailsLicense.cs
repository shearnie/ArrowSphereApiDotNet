using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record LicenseDetailsLicense(
        DateTime Activation_Datetime,
        ActiveSeats ActiveSeats,
        IEnumerable<string> ArrowSubCategories,
        string AssociatedSubscriptionProgram,
        bool AutoRenew,
        string Category,
        string Customer_ref,
        DateTime Expiry_Datetime,
        string FriendlyName,
        bool IsAddon,
        bool IsTrial,
        string License_Id,
        string Marketplace,
        string Parent_License_Id,
        string Name,
        string Message,
        Order Order,
        string Periodicity,
        int PeriodicityCode,
        Price Price,
        PriceBand PriceBand,
        string Program,
        Rates Rates,
        int Seats,
        string Service_Ref,
        string Sku,
        string State,
        int StatusCode,
        string Term,
        int TermCode,
        string VendorBillingId,
        string VendorSku,
        string Vendor_Code,
        string Vendor_License_Id,
        Assets Assets,
        string Classification,
        IEnumerable<Config> Configs,
        string MarketSegment,
        DateTime NextRenewalDate,
        string Order_Reference,
        IEnumerable<Relation> Relation,
        IEnumerable<Warning> Warnings)
    {
    }
}
