﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public class VehicleBase
    {
        public int Id { get; set; }

        [Display(Name = "Medlemsnamn")]
        public string MemberName { get; set; }

        [Display(Name = "Registeringsnummer")]
        public string RegNumber { get; set; }

        [Display(Name = "Fordonstyp")]
        public string VehicleType { get; set; }

        [Editable(false)]
        [Display(Name = "Check-in tid")]
        [DisplayFormat(DataFormatString = "{0: HH:mm:ss  ddd d MMM yyyy}")]
        public DateTime CheckInTime { get; set; }
    }
}