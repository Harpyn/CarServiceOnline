using CarServiceCare.Common.Enums.Insurance;
using System;
using System.ComponentModel.DataAnnotations;


namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class CarInsurance : BaseEntity
    {
        public Car Car { get; set; }
        public TypeOfInsuranceEnum InsuranceType { get; set; }
        public InsuranceCompanyEnum InsuranceCompany { get; set; }
        public DateTime ValidTo { get; set; }
        public decimal Price { get; set; }
    }
}
