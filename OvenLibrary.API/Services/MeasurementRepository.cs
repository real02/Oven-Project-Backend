using OvenLibrary.API.DbContexts;
using OvenLibrary.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Services
{
    public class MeasurementRepository : IMeasurementRepository, IDisposable
    {
        private readonly OvensContext _context;
        public MeasurementRepository(OvensContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddMeasurement(Measurement measurement)
        {
            if (measurement == null)
            {
                throw new ArgumentNullException(nameof(measurement));
            }

            try
            {
                _context.Measurements.Add(measurement);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid format, expected type of Measurement");
            }
        }

        public void DeleteMeasurement(Measurement measurement)
        {
            if (MeasurementExists(measurement.MeasurementId))
            {
                _context.Measurements.Remove(measurement);
            }
            else
            {
                throw new ArgumentException("Measurement with given id doesn't exist.");
            }
        }

        public Measurement GetMeasurement(long measurementID)
        {
            return _context.Measurements.FirstOrDefault(m => m.MeasurementId == measurementID);
        }

        public IEnumerable<Measurement> GetMeasurements()
        {
            return _context.Measurements.ToList<Measurement>();
        }
        public bool MeasurementExists(long measurementId)
        {
            return _context.Measurements.Any(m => m.MeasurementId == measurementId);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
