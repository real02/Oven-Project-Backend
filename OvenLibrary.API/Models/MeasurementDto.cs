using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Models
{
    public class MeasurementDto
    {
        public Int64 OvenId { get; set; }
        public DateTime DateTime { get; set; }
        public double Temperature { get; set; }
        public double PowerConsumption { get; set; }
    }
}
