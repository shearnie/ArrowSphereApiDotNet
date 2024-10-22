using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models
{
    public record ArrowError(
        int Status,
        string Error,
        string ErrorCode,
        string CorrelationId)
    {
        public ArrowError() : this(default, string.Empty, string.Empty, string.Empty)
        {
        }
    }
}
