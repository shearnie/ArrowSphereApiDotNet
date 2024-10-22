using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record Customer(
        string Reference,
        string Link)
    {
        public Customer() : this(string.Empty, string.Empty)
        {
        }
    }
}
