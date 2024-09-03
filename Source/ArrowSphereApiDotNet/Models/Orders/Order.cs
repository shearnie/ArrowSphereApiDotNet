using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record Order(
        string Reference,
        string Status,
        DateTime DateStatus,
        DateTime DateCreation,
        string Order_Reference,
        string CreatedBy,
        string CreatedByImpersonator,
        decimal CommitmentAmountTotal,
        Partner Partner,
        Customer Customer,
        string PoNumber,
        IEnumerable<Product> Products)
    {
    }
}
