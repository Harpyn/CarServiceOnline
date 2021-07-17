using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCare.DataAccess.Data.Images
{
    public abstract class BaseImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
    }
}
