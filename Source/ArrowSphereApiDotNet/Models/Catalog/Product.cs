using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
	public record Product(
		string Id,
		string MarketPlace,
		string Sku,
		string Name,
		string Type,
		string Vendor,
		string Vendor_Code,
		IEnumerable<dynamic> Category,
		IEnumerable<string> Arrow_Sub_Categories,
		string Customer_Category,
		string Service_Ref,
		string Service_Name,
		IEnumerable<string> Keywords,
		bool Is_Addon,
		bool Has_Addons,
		bool Is_Trial,
		string Thumbnail,
		string Square_Logo,
        IEnumerable<Price> Prices,
		IEnumerable<string> MarketSegments,
		decimal Weight_Top_Sales,
		int Weight_Forced,
		bool IsEnabled,
		Program Program,
		IEnumerable<dynamic> Prerequisites,
		IEnumerable<string> Add_Ons,
		string Orderable_Sku)
    {
        public Product() : this(
			string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 
			new List<dynamic>(), new List<string>(), string.Empty, string.Empty, string.Empty, new List<string>(),
            false, false, false, string.Empty, string.Empty, new List<Price>(), new List<string>(),
			default, default, false, new Program(), new List<dynamic>(), new List<string>(), string.Empty)
        {
        }
    }
}
