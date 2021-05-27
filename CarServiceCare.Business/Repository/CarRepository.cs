using AutoMapper;
using CarServiceCare.Business.Repository.IRepository;
using CarServiceCare.DataAccess.Data;
using CarServiceCare.DataAccess.Data.DbModels;
using CarServiceCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCare.Business.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CarRepository(ApplicationDbContext db, IMapper mapper)
        {
            
            _mapper = mapper;
            _db = db;
        }

        public async Task<CarDTO> CreateCar(CarDTO carDTO)
        {
            Car car = _mapper.Map<CarDTO, Car>(carDTO);
            var addCar = await _db.Cars.AddAsync(car);
            await _db.SaveChangesAsync();
            return _mapper.Map<Car, CarDTO>(addCar.Entity);
        }

        public Task<IEnumerable<CarDTO>> GetAllCar()
        {
            throw new NotImplementedException();
        }

        public Task<CarDTO> GetCar(int carId)
        {
            throw new NotImplementedException();
        }

        public Task<CarDTO> IsSameCarAlreadyPresent(string name)
        {
            throw new NotImplementedException();
        }

        public Task<CarDTO> UpdateCar(int carId, CarDTO carDTO)
        {
            throw new NotImplementedException();
        }
    }
}
