﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Billing
{
    public record Pagination(
        int PerPage,
        int CurrentPage,
        int Total,
        int TotalPages)
    {
        public Pagination() : this(default, default, default, default)
        {
        }
    }
}
