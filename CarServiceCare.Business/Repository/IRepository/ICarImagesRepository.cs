using CarServiceCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCare.Business.Repository.IRepository
{
    public interface ICarImagesRepository
    {
        public Task<int> CreateCarImage(CarImageDTO image);
        public Task<int> DeleteCarImageByImageId(int imageId);
        public Task<int> DeleteCarImageByCarId(int carId);
        public Task<IEnumerable<CarImageDTO>> GetCarImages(int carId);
    }
}
