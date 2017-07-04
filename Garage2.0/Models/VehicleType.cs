using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0.Models
{
    public enum TypeOfVehicle
    {
        //[Display(Name = "Bil")]
        Bil,
        //[Display(Name = "Buss")]
        Buss,
        //[Display(Name = "Båt")]
        Båt,
        //[Display(Name = "Flygplan")]
        Flygplan,
        //[Display(Name = "Motorcykel")]
        Motorcykel
    }

    public class VehicleType
    {
        public int Id { get; set; }

        [Display(Name = "Fordonstyp")]
        public TypeOfVehicle TypeOfVehicle { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}