﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Customers
{
    public record Customer(
        string Reference,
        string WorkgroupCode,
        string CompanyName,
        string CompanyAcronym,
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
        string BillingAddress1,
        string BillingAddress2,
        string BillingCity,
        string BillingState,
        string BillingZipCode,
        string BillingCountryCode,
        string InternalReference,
        string Type,
        Contact Contact,
        OrganizationUnit OrganizationUnit,
        Reseller Reseller,
        CustomerDetail Details,
        ExtraInformation ExtraInformation,
        DateTime CreatedAt,
        DateTime? DeletedAt,
        bool PoNumberMandatory,
        IEnumerable<string> PartnerTags,
        string AdminNote,
        string Isr,
        string Fsr)
    {
        public Customer() : this(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                 string.Empty, string.Empty, string.Empty, string.Empty, default, string.Empty, string.Empty, string.Empty,
                                 string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                 new Contact(), new OrganizationUnit(), new Reseller(), new CustomerDetail(), new ExtraInformation(), default, null, false, new List<string>(),
                                 string.Empty, string.Empty, string.Empty)
        {
        }
    }
}
