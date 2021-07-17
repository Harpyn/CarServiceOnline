using AutoMapper;
using CarServiceCare.Business.Repository.IRepository;
using CarServiceCare.DataAccess.Data;
using CarServiceCare.DataAccess.Data.Images;
using CarServiceCare.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarServiceCare.Business.Repository
{
    public class CarImagesRepository : ICarImagesRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CarImagesRepository(ApplicationDbContext db, IMapper mapper)
        {

            _mapper = mapper;
            _db = db;
        }

        public async Task<int> CreateCarImage(CarImageDTO imageDTO)
        {
            var image = _mapper.Map<CarImageDTO, CarImage>(imageDTO);
            await _db.CarImages.AddAsync(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteCarImageByCarId(int carId)
        {
            var imageList = await _db.CarImages.Where(x => x.CarId == carId).ToListAsync();
            _db.CarImages.RemoveRange(imageList);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteCarImageByImageId(int imageId)
        {
            var image = await _db.CarImages.FindAsync(imageId);
            _db.CarImages.Remove(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<CarImageDTO>> GetCarImages(int carId)
        {
            return _mapper.Map<IEnumerable<CarImage>, IEnumerable<CarImageDTO>>(
            await _db.CarImages.Where(x => x.CarId == carId).ToListAsync());
        }
    }
}
