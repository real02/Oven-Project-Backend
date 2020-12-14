using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Entities
{
    public class Oven
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 OvenId { get; set; }

        [Required]
        public string Address { get; set; }

        public ICollection<Measurement> Measurements { get; set; }
            = new List<Measurement>();

        [Required]
        public double LocationLatitude { get; set; }

        [Required]
        public double LocationLongitude { get; set; }
    }
}
