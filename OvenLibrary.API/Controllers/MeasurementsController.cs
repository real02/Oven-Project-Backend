using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OvenLibrary.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Controllers
{

    [ApiController]
    [Route("/api/measurements")]
    public class MeasurementsController : ControllerBase
    {
        private readonly IMeasurementRepository _measurementsRepository;
        private readonly IMapper _mapper;

        public MeasurementsController(IMeasurementRepository measurementRepository, IMapper mapper)
        {
            _measurementsRepository = measurementRepository ?? throw new ArgumentNullException(nameof(measurementRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Entities.Measurement>> GetMeasurements()
        {
            var measurements = _measurementsRepository.GetMeasurements();

            return Ok(measurements);
        }

        [HttpPost(Name = "AddMeasurement")]
        public ActionResult<Entities.Measurement> AddMeasurement(Models.MeasurementDto measurement)
        {
            var measurementEntity = _mapper.Map<Entities.Measurement>(measurement);
            _measurementsRepository.AddMeasurement(measurementEntity);
            _measurementsRepository.Save();

            return CreatedAtRoute("AddMeasurement",
                new { measurementId = measurementEntity.MeasurementId },
                measurementEntity);
        }


    }
}
