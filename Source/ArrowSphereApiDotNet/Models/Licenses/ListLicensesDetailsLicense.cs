﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Licenses
{
    public record ListLicensesDetailsLicense(
        string License_Id,
        string Parent_License_Id,
        string FriendlyName,
        string Customer_Ref,
        string State,
        int StatusCode,
        bool IsTrial,
        bool IsAddon,
        string Service_Ref,
        string Sku,
        string Name,
        int Seats,
        ActiveSeats ActiveSeats,
        DateTime Activation_Datetime,
        DateTime Expiry_Datetime,
        string Message,
        Order Order,
        string VendorBillingId,
        string Vendor_License_Id,
        string Periodicity,
        int PeriodicityCode,
        string Term,
        int TermCode,
        string Category,
        string Program,
        string AssociatedSubscriptionProgram,
        bool AutoRenew,
        Price Price,
        IEnumerable<string> ArrowSubCategories,
        PriceBand PriceBand,
        string Vendor_Code)
    {
    }
}
/*
{


                "price": {
                    "priceBandArrowsphereSku": "MS_IAAS_DZH318Z0BPS6_0001_USD",
                    "currency": "USD",
                    "unit": {
                        "buy": 0,
                        "sell": 0,
                        "list": 0
                    },
                    "total": {
                        "buy": 0,
                        "sell": 0,
                        "list": 0
                    }
                },

                "priceBand": {
                    "saleConstraints": {
                        "minQuantity": 1,
                        "maxQuantity": 1
                    }
                },

            },
 */