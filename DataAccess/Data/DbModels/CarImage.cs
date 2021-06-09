using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class CarImage
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey("CarId")]
        public virtual Car Car { get; set; }
    }
}
