using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record OrderDetails(
        int Status,
        OrderDetail Data)
    {
        public OrderDetails() : this(default, new OrderDetail())
        {
        }
    }
}
