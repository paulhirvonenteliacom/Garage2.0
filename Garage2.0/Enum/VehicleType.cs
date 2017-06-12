using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Garage2._0.Enum
{
    public enum TypeOfVehicle
    {
        [Display(Name = "Bil")]
        Car,
        [Display(Name = "Buss")]
        Bus,
        [Display(Name = "Båt")]
        Boat,
        [Display(Name = "Flygplan")]
        Airplane,
        [Display(Name = "Motorcykel")]
        Motorcycle
    }
}