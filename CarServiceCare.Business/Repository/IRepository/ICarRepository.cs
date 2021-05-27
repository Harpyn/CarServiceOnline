using CarServiceCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCare.Business.Repository.IRepository
{
    public interface ICarRepository
    {
        public Task<CarDTO> CreateCar(CarDTO carDTO);
        public Task<CarDTO> UpdateCar(int carId, CarDTO carDTO);
        public Task<CarDTO> GetCar(int carId);
        public Task<IEnumerable<CarDTO>> GetAllCar();
        public Task<CarDTO> IsSameCarAlreadyPresent(string name);

    }
}
