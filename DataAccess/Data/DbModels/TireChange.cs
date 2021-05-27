using System.ComponentModel.DataAnnotations;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class TireChange : BaseEntity
    {
        public Car Car { get; set; }
        //Počet

        public int Quantity { get; set; }
        //Značka

        public string TireManufacturer { get; set; }
        //Znovu vyváženo

        public string Balanced { get; set; }
        //Servis
  
        public string CarService { get; set; }
        //Tachometr

        public int Kilometer { get; set; }
        //Cena
  
        public decimal Price { get; set; }

    }
}
