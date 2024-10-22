using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models
{
    public record User(
        string Login,
        string FirstName,
        string LastName,
        string Email,
        string Role,
        string Code)
    {
        public User() : this(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty)
        {
        }
    }
}
