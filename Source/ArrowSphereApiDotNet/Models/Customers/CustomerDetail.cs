﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Customers
{
    public record CustomerDetail(
        bool Migration,
        string DomainName,
        string OracleOnlineKey,
        string IBMCeId,
        string Maas360ResellerId,
        string TenantId,
        string IbmCustomerNumber,
        string IbmMaasAccountId)
    {
        public CustomerDetail() : this(false, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty)
        {
        }
    }
}
