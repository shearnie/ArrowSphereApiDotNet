using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record CreateOrderResponse(
        int Status,
        CreateOrderResponseData Data)
    {
        public CreateOrderResponse() : this(default, new CreateOrderResponseData())
        {
        }
    }
}
