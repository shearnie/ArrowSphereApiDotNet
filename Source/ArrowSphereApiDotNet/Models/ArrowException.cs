using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowSphereApiDotNet.Models
{
    public class ArrowException : Exception
    {
        public ArrowError ArrowError { get; set; } = new ArrowError(0, string.Empty, string.Empty, string.Empty);
		public override string Message => ArrowError.Error;
	}
}
