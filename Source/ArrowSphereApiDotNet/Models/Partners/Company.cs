using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Partners
{
    public record Company(
        string CompanyName,
        string AddressLine1,
        string AddressLine2,
        string Zip,
        string City,
        string CountryCode,
        string State,
        string ReceptionPhone,
        string WebsiteUrl,
        string EmailContact,
        int HeadCount,
        string TaxNumber,
        string Reference,
        string Ref,
        string BillingId,
        string InternalReference,
        User User)
    {
        public Company() : this(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, default,
                                string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, new User())
        {
        }
    }
}
