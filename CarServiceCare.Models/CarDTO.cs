using CarServiceCare.Common.Enums.Car;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCare.Models
{
    public class CarDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vyplňte jméno pro identifikace vozidla, může být libovolné")]
        public string Name { get; set; }
        [Required]
        public CarBrandsEnum CarBrand { get; set; }
        [Required]
        public VehicleTypesEnum VehicleType { get; set; }
        [Required]
        public FuelTypesEnum FuelType { get; set; }

        public int CubicCapacity { get; set; }

        public int Power { get; set; }

        public string VIN { get; set; }

        public int Kilometer { get; set; }

        public int Owners { get; set; }

        public decimal Price { get; set; }

        [Required(ErrorMessage = "Datum první registrace musí být vyplněn")]
        public DateTime FirstRegistration { get; set; }

        [Required(ErrorMessage = "Datum nákupu musí být vyplněn")]
        public DateTime DateOfPurchase { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public string LicensePlate { get; set; }

        public virtual ICollection<CarImageDTO> CarImages { get; set; }

        public List<string> ImageUrls { get; set; }
    }
}
