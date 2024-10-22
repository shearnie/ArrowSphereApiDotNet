using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Customers
{
    public record UpdateCustomerResponse(
        int Status,
        UpdateCustomerResponseData Data)
    {
        public UpdateCustomerResponse() : this(default, new UpdateCustomerResponseData())
        {
        }
    }
}
