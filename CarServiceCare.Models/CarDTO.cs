using CarServiceCare.Common.Enums.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCare.Models
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CarBrandsEnum CarBrand { get; set; }

        public VehicleTypesEnum VehicleType { get; set; }

        public FuelTypesEnum FuelType { get; set; }

        public int CubicCapacity { get; set; }

        public int Power { get; set; }

        public string VIN { get; set; }

        public int Kilometer { get; set; }

        public int Owners { get; set; }

        public decimal Price { get; set; }

        public DateTime FirstRegistration { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public string LicensePlate { get; set; }
    }
}
