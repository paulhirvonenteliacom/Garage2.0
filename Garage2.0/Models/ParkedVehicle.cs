using Garage2._0.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public class ParkedVehicle
    {
        public ParkedVehicle()
        {
            CheckInTime = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Typ av fordon")]
        public TypeOfVehicle TypeOfVehicle { get; set; }

        [Display(Name = "Registeringsnummer")]
        [Required(ErrorMessage = "{0} måste anges!")]
        [RegularExpression(@"\D{1,3}\w+", ErrorMessage = "Ange ett giltigt {0}")]
        [MaxLength(16)]
        public string RegNumber { get; set; }

        [MaxLength(30)]
        [Display(Name = "Färg")]
        public string Color { get; set; }

        [Range(0, 20)]
        [Display(Name = "Antal hjul")]
        public int NoOfWheels { get; set; }

        [MaxLength(30)]
        [Display(Name = "Märke")]
        public string Brand { get; set; }

        [MaxLength(30)]
        [Display(Name = "Modell")]
        public string Model { get; set; }

        [Editable(false)]
        [Display(Name = "Check-in tid")]
        [DisplayFormat(DataFormatString = "{0: hh:mm:ss  ddd d MMM}")]
        public DateTime CheckInTime { get; set; }
    }
}