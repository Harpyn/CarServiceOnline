using System.ComponentModel.DataAnnotations;
using CarServiceCare.Common.Enums.Expense;

namespace CarServiceCare.DataAccess.Data.DbModels
{
    public class Expense : BaseEntity
    {

        [Display(Name = "Auto")]
        public Car Car { get; set; }
        //Druh
        public ExpensesEnum Type { get; set; }
        //Cena
        public decimal Price { get; set; }

    }
}
