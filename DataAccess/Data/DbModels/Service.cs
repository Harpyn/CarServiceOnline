using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class Service : BaseEntity
    {

 
        public virtual Car Car { get; set; }
        //Kategorie
    
        public string ServiceType { get; set; }
        //Servis
  
        public string CarService { get; set; }
        //Rozsah

        public string Description { get; set; }
        //Tachometr
        public string Kilometer { get; set; }
        //Cena
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

    }
}
