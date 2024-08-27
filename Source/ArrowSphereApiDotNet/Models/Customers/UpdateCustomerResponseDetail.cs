using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Customers
{
    public record UpdateCustomerResponseDetail(
        string Reference,
        string WorkgroupCode,
        string CompanyName,
        string PartnerCompanyId,
        string AddressLine1,
        string AddressLine2,
        string Zip,
        string City,
        string CountryCode,
        string State,
        string ReceptionPhone,
        string WebsiteUrl,
        string EmailContact,
        int Headcount,
        string TaxNumber,
        string Ref,
        string RegistrationNumber,
        string BillingId,
        string InternalReference,
        Reseller Reseller,
        string Type,
        Contact Contact,
        OrganizationUnit OrganizationUnit,
        CustomerDetail Details,
        ExtraInformation ExtraInformation,
        DateTime CreatedAt,
        DateTime? DeletedAt)
    {
    }
}
