using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
	public record Price(
        float Min_Quantity,
        float Max_Quantity,
        decimal Recurring_Buy_Price,
        decimal Recurring_Sell_Price,
        string Term,
        string Unit_Type,
        string Recurring_Time_Unit,
        string Currency,
        int Period_As_Hours,
        int Term_As_Hours)
	{
    }
}
