using AutoMapper;
using CarServiceCare.DataAccess.Data.DbModels;
using CarServiceCare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCare.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CarDTO, Car>();
            CreateMap<Car, CarDTO>();
        }
    }
}
