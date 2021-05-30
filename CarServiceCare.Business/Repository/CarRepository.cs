using AutoMapper;
using CarServiceCare.Business.Repository.IRepository;
using CarServiceCare.DataAccess.Data;
using CarServiceCare.DataAccess.Data.DbModels;
using CarServiceCare.Models;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<CarDTO>> GetAllCar()
        {
            try
            {
                IEnumerable<CarDTO> carDTOs = _mapper.Map<IEnumerable<Car>, IEnumerable<CarDTO>>(_db.Cars);
                return carDTOs;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<CarDTO> GetCar(int carId)
        {
            try
            {
                CarDTO car = _mapper.Map<Car, CarDTO>(await _db.Cars.FirstOrDefaultAsync(x => x.Id == carId));

                return car;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> DeleteCar(int carId)
        {

                var carDetails = await _db.Cars.FindAsync(carId);
                if(carDetails != null) 
                {
                    _db.Cars.Remove(carDetails);
                    return await _db.SaveChangesAsync();
                }

                return 0;

        }

        public async Task<CarDTO> IsCarUnique(string name)
        {
            try
            {
                CarDTO car = _mapper.Map<Car, CarDTO>(await _db.Cars.FirstOrDefaultAsync(x => x.Name == name));

                return car;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<CarDTO> UpdateCar(int carId, CarDTO carDTO)
        {   
            try
            {
                if(carId == carDTO.Id)
                {
                    Car carDetails = await _db.Cars.FindAsync(carId);
                    Car car = _mapper.Map<CarDTO, Car>(carDTO, carDetails);
                    var updatedCar = _db.Cars.Update(car);
                    await _db.SaveChangesAsync();
                    return _mapper.Map<Car, CarDTO>(updatedCar.Entity);
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
