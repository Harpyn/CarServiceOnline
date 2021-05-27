using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CarServiceCare.Common.Enums.Car;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class Car : BaseEntity
    {
        public User User { get; set; }

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
