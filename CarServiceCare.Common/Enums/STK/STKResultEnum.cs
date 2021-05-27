using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCare.Common.Enums.STK
{
    public enum STKResultEnum
    {
        [Display(Name = "Prošlo")]
        Passed,
        [Display(Name = "Neprošlo")]
        NotPassed,
    }
}
