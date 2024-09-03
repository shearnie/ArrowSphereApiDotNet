using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Orders
{
    public record Price(
        decimal Buy,
        decimal Sell,
        string Currency,
        string Periodicity,
        string Term,
        string PeriodicityCode,
        string TermCode)
    {
    }
}
