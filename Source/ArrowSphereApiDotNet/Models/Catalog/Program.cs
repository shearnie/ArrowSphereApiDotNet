﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models.Catalog
{
	public record Program(
		bool IsEnabled)
    {
        public Program() : this(false)
        {
        }
    }
}
