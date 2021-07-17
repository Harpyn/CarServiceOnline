using CarServiceCare.Common.Enums.Insurance;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class CarInsurance : BaseEntity
    {
        public virtual Car Car { get; set; }
        public TypeOfInsuranceEnum InsuranceType { get; set; }
        public InsuranceCompanyEnum InsuranceCompany { get; set; }
        public DateTime ValidTo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
