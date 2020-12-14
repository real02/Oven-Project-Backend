using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Models
{
    public class OvenForUpdateDto
    {
        public string Address { get; set; }

        public double LocationLatitude { get; set; }

        public double LocationLongitude { get; set; }
    }
}
