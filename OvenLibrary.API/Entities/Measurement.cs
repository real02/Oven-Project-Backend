using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Entities
{
    public class Measurement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 MeasurementId { get; set; }

        [ForeignKey("Oven")]
        public Int64 OvenId { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public double Temperature { get; set; }

        public double TemperatureInFahrenheit { get; set; }

        [Required]
        public double PowerConsumption { get; set; }
    }
}
