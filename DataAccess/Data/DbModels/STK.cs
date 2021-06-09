using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarServiceCare.Common.Enums.STK;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class STK : BaseEntity
    {

        public virtual Car Car { get; set; }
  
        public DateTime ValidTo { get; set; }
      
        public string Station { get; set; }
  
        public string Description { get; set; }

        public int Kilometer { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
 
        public STKResultEnum Passed { get; set; }
    }
}
