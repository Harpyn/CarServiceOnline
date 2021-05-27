using System.ComponentModel.DataAnnotations;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class Service : BaseEntity
    {

 
        public Car Car { get; set; }
        //Kategorie
    
        public string ServiceType { get; set; }
        //Servis
  
        public string CarService { get; set; }
        //Rozsah

        public string Description { get; set; }
        //Tachometr
        public string Kilometer { get; set; }
        //Cena
     
        public decimal Price { get; set; }

    }
}
