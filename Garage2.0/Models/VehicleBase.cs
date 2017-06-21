using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public class VehicleBase
    {
        [Display(Name = "Ägare")]
        public string MemberName { get; set; }

        [Display(Name = "Registeringsnummer")]
        public string RegNumber { get; set; }

        [Display(Name = "Fordonstyp")]
        public string VehicleType { get; set; }

        [Editable(false)]
        [Display(Name = "Check-in tid")]
        [DisplayFormat(DataFormatString = "{0: hh:mm:ss  ddd d MMM}")]
        public DateTime CheckInTime { get; set; }
    }
}