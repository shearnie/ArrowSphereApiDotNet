using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Customers
{
    public class UpdateCustomerRequest
    {
        public string Reference { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ReceptionPhone { get; set; } = string.Empty;
        public string WebsiteUrl { get; set; } = string.Empty;
        public string EmailContact { get; set; } = string.Empty;
        public int Headcount { get; set; }
        public string TaxNumber { get; set; } = string.Empty;
        public string Ref { get; set; } = string.Empty;
        public string BillingId { get; set; } = string.Empty;
        public string InternalReference { get; set; } = string.Empty;
        public Contact Contact { get; set; } = new();
        public OrganizationUnit OrganizationUnit { get; set; } = new();
        ExtraInformation ExtraInformation { get; set; } = new();
    }
}
