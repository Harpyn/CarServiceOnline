using System.ComponentModel.DataAnnotations;
using CarServiceCare.Common.Enums.Repair;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class Repair : BaseEntity
    {


        public Car Car { get; set; }
        //Oprava

        public string RepairType { get; set; }
        //Odhadovaná cena

        public decimal EstimatedPrice { get; set; }
        //Priorita

        public PriorityEnum Priority { get; set; }

    }
}
