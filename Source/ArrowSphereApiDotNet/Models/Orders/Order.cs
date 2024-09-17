using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record Order(
        string Order_Reference,
        string Reference,
        string Status,
        string DateStatus,
        string DateCreation,
        string PoNumber,
        Partner Partner,
        Customer Customer,
        IEnumerable<Product> Products,
        ExtraInformation ExtraInformation,
        string CreatedBy,
        string CreatedByImpersonator,
        decimal CommitmentAmountTotal)
    {
    }
}
