using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Customers
{
    public record CustomerDetails(
        int Status,
        ListCustomersData Data)
    {
        public CustomerDetails() : this(default, new ListCustomersData())
        {
        }
    }
}
