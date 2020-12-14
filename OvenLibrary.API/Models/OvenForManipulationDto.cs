using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Models
{
    public abstract class OvenForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out an address.")]
        [MaxLength(100, ErrorMessage = "The address shouldn't have more than 100 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "You should fill out location latitude.")]
        public double LocationLatitude { get; set; }

        [Required(ErrorMessage = "You should fill out location longitude.")]
        public double LocationLongitude { get; set; }
    }
}
