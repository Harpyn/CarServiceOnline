using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CarServiceCare.Common.Enums.Car;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class Car : BaseEntity
    {
        [Required]
        public User User { get; set; }
        [Required]
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
        [Required]
        public DateTime FirstRegistration { get; set; }
        [Required]
        public DateTime DateOfPurchase { get; set; }
    
        public string Model { get; set; }

        public string Color { get; set; }
  
        public string LicensePlate { get; set; }      


        //reference to objects
        public ICollection<STK> STK { get; set; }
        public ICollection<CarInsurance> CarInsurances { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<Refueling> Refuelings { get; set; }
        public ICollection<Repair> Repairs { get; set; }
        public ICollection<Service> Services { get; set; }     
        public ICollection<TireChange> TireChanges { get; set; }

    }
}
