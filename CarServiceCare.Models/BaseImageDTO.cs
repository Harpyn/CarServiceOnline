using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCare.Models
{
    public abstract class BaseImageDTO
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
    }
}
