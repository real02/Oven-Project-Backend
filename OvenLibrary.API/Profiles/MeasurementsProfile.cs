using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Profiles
{
    public class MeasurementsProfile : Profile
    {
        public MeasurementsProfile()
        {
            CreateMap<Entities.Measurement, Models.MeasurementDto>();
            CreateMap<Models.MeasurementDto, Entities.Measurement>();
        }
    }
}
