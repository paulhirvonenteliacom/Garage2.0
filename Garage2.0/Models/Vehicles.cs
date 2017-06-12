using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0.Models
{
    public class Vehicles
    {
        //[Display(Name = "Typ")]
        //public VehicleType Type { get; set; }

        [Display(Name = "Registreringsnummer")]
        [Required(ErrorMessage = "{0} måste anges!")]
        [RegularExpression(@"\D{1,3}\w+", ErrorMessage = "Ange ett giltigt {0}")]
        public string RegNr { get; set; }

        [Display(Name = "Färg")]
        public string Color { get; set; }
    }
}