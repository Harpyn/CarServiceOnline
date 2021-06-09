using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarServiceCare.Common.Enums.Repair;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class Repair : BaseEntity
    {


        public virtual Car Car { get; set; }
        //Oprava

        public string RepairType { get; set; }
        //Odhadovaná cena
        [Column(TypeName = "decimal(18,4)")]
        public decimal EstimatedPrice { get; set; }
        //Priorita

        public PriorityEnum Priority { get; set; }

    }
}
