using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Customers
{
	public record CreateCustomerResponse(
        int Status,
        CreateCustomerResponseData Data)
    {
        public CreateCustomerResponse() : this(default, new CreateCustomerResponseData())
        {
        }
    }
}
