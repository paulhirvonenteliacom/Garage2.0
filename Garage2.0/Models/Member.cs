﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Telefonnummer")]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}