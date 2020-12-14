using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Profiles
{
    public class OvensProfile : Profile
    {
        public OvensProfile()
        {
            CreateMap<Entities.Oven, Models.OvenForCreationDto>();
            CreateMap<Models.OvenForCreationDto, Entities.Oven>();
            CreateMap<Models.OvenForUpdateDto, Entities.Oven>();
        }
    }
}
