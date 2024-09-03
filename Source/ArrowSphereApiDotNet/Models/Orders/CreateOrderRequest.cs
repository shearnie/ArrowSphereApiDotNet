using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public class CreateOrderRequest
    {
        public DateTime? ScheduledDate { get; set; }
        public CreateOrderCustomer Customer { get; set; } = new();
        public IEnumerable<CreateOrderProduct> Products { get; set; } = new List<CreateOrderProduct>();
        public string OrganizationUnitRef { get; set; } = string.Empty;
    }
}
