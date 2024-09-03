using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public class CreateOrderCustomer
    {
        public string Reference { get; set; } = string.Empty;
        public string PoNumber { get; set; } = string.Empty;
    }
}
