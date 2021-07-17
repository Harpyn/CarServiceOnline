using AutoMapper;
using CarServiceCare.DataAccess.Data.DbModels;
using CarServiceCare.DataAccess.Data.Images;
using CarServiceCare.Models;

namespace CarServiceCare.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CarDTO, Car>();
            CreateMap<Car, CarDTO>();

            CreateMap<CarImage, CarImageDTO>().ReverseMap();
        }
    }
}
