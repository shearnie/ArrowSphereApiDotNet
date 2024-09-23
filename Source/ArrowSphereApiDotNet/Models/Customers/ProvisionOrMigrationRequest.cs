using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Customers
{
    public class ProvisionOrMigrationRequest
    {
        public string Program { get; set; } = string.Empty;
        public IEnumerable<Attribute> Attributes { get; set; } = new List<Attribute>();
    }
}
