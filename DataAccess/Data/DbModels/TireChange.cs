using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class TireChange : BaseEntity
    {
        public virtual Car Car { get; set; }
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
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

    }
}
