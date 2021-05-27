using System;
using System.ComponentModel.DataAnnotations;
using CarServiceCare.Common.Enums.STK;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class STK : BaseEntity
    {

        public Car Car { get; set; }
  
        public DateTime ValidTo { get; set; }
      
        public string Station { get; set; }
  
        public string Description { get; set; }

        public int Kilometer { get; set; }

        public decimal Price { get; set; }
 
        public STKResultEnum Passed { get; set; }
    }
}
