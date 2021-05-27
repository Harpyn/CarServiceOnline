using System.ComponentModel.DataAnnotations;

namespace CarServiceCare.Common.Enums.Repair
{
    public enum PriorityEnum
    {
        [Display(Name = "Nízká")]
        Low,
        [Display(Name = "Střední")]
        Medium,
        [Display(Name = "Vysoká")]
        High
    }
}
