using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CarServiceCare.Common.Enums.Expense;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class Expense : BaseEntity
    {

        [Display(Name = "Auto")]
        public virtual Car Car { get; set; }
        //Druh
        public ExpensesEnum Type { get; set; }
        //Cena
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

    }
}
