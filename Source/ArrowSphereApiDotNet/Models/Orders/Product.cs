using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record Product(
        string Sku,
        string Name,
        string Classification,
        string VendorName,
        string ProgramName,
        Program Program,
        Identifier Identifiers,
        int Quantity,
        string Status,
        DateTime DateStatus,
        string DetailedStatus,
        bool IsAddon,
        bool IsTrial,
        IEnumerable<string> ArrowSubCategories,
        Price Prices,
        Subscription Subscription,
        License License,
        ExtraInformation ExtraInformation)
    {
    }
}
