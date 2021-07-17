using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarServiceCare.Common.Enums.Car;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class Refueling : BaseEntity
    {


        public virtual Car Car { get; set; }
        //Stanice
  
        public string FuelStation { get; set; }
        //Palivo
  
        public FuelTypesEnum FuelType { get; set; }
        //Trasa
  
        public string Route { get; set; }
        //Styl jízdy
     
        public string DrivingStyle { get; set; }
        //Ujeto
        public int Distance { get; set; }
        //Spotřeba
        public int FuelConsumption { get; set; }
        //Litrů
        public int? Liters { get; set; }
        //Cena za litr
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PriceForLiter { get; set; }
        //Cena
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
