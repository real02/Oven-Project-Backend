using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OvenLibrary.API.Entities;
using OvenLibrary.API.Models;
using OvenLibrary.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Controllers
{
    [ApiController]
    [Route("/api/ovens")]
    public class OvenController : ControllerBase
    {
        private readonly IOvenRepository _ovenRepository;
        private readonly IMapper _mapper;

        public OvenController(IOvenRepository ovenRepository, IMapper mapper)
        {
            _ovenRepository = ovenRepository ?? throw new ArgumentNullException(nameof(ovenRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Entities.Oven>> GetOvens()
        {
            var ovens = _ovenRepository.GetOvens();

            return Ok(ovens);
        }

        [HttpGet("{ovenId}", Name = "GetOven")]
        public IActionResult GetOven(long ovenId)
        {
            var ovenFromRepo = _ovenRepository.GetOven(ovenId);

            if (ovenFromRepo == null)
            {
                return NotFound();
            }

            return Ok(ovenFromRepo);
        }

        [HttpPost]
        public ActionResult<Entities.Oven> AddOven(Models.OvenForCreationDto oven)
        {
            var ovenEntity = _mapper.Map<Entities.Oven>(oven);
            _ovenRepository.AddOven(ovenEntity);
            _ovenRepository.Save();

            return CreatedAtRoute("GetOven",
                new { ovenId = ovenEntity.OvenId },
                ovenEntity);
        }

        [HttpPut("{ovenId}")]
        public ActionResult UpdateOven(long ovenId, OvenForUpdateDto oven)
        {
            var ovenFromRepo = _ovenRepository.GetOven(ovenId);

            if (ovenFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(oven, ovenFromRepo);

            _ovenRepository.UpdateOven(ovenFromRepo);

            _ovenRepository.Save();

            return NoContent();
        }
    }
}
