using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models
{
    public record Pagination(
        int Per_Page,
        int Current_Page,
        int Total_Page,
        int Total,
        string? Next,
        string? Previous)
    {
        public Pagination() : this(default, default, default, default, string.Empty, string.Empty)
        {
        }
    }
}
