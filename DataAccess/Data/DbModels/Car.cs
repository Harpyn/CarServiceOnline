using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarServiceCare.Common.Enums.Car;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class Car : BaseEntity
    {
        [Required]
        public virtual User User { get; set; }
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
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [Required]
        public DateTime FirstRegistration { get; set; }
        [Required]
        public DateTime DateOfPurchase { get; set; }
    
        public string Model { get; set; }

        public string Color { get; set; }
  
        public string LicensePlate { get; set; }      


        //reference to objects
        public virtual ICollection<STK> STK { get; set; }
        public virtual ICollection<CarInsurance> CarInsurances { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Refueling> Refuelings { get; set; }
        public virtual ICollection<Repair> Repairs { get; set; }
        public virtual ICollection<Service> Services { get; set; }     
        public virtual ICollection<TireChange> TireChanges { get; set; }
        public virtual ICollection<CarImage> CarImages { get; set; }

    }
}
