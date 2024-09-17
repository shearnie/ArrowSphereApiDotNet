using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record ListOrders(
        int Status,
        ListOrdersDetails Data,
        Pagination Pagination)
    {
    }
}
