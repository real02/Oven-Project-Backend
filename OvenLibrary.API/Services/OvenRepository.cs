using Microsoft.EntityFrameworkCore;
using OvenLibrary.API.DbContexts;
using OvenLibrary.API.Entities;
using OvenLibrary.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Services
{
    public class OvenRepository : IOvenRepository
    {
        private readonly OvensContext _context;

        public OvenRepository(OvensContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public void AddOven(Oven oven)
        {
            if (oven == null)
            {
                throw new ArgumentNullException(nameof(oven));
            }

            try
            {
                _context.Ovens.Add(oven);

                foreach (var measurement in oven.Measurements)
                {
                    _context.Measurements.Add(measurement);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid format, expected type of Oven");
            }
        }
        public Oven GetOven(long ovenId)
        {
            return _context.Ovens.Include(o => o.Measurements).FirstOrDefault(o => o.OvenId == ovenId);
        }
        public ICollection<Measurement> GetMeasurements(long ovenId)
        {
            if (OvenExists(ovenId)) //oven has to exist
            {
                Oven oven = GetOven(ovenId);
                return oven.Measurements;
            }
            throw new ArgumentException("Oven with given id doesn't exist.");
        }

        public IEnumerable<Oven> GetOvens()
        {
            return _context.Ovens.Include(o => o.Measurements).ToList();
        }
        public void DeleteOven(Oven oven)
        {
            if (OvenExists(oven.OvenId))
            {
                _context.Ovens.Remove(oven);
            }
            else
            {
                throw new ArgumentException("Oven with given id doesn't exist.");
            }
        }
        public void AddMeasurement(long ovenId, Measurement measurement)
        {
            if (OvenExists(ovenId)) //oven has to exist
            {
                _context.Ovens.FirstOrDefault(o => o.OvenId == ovenId).Measurements.Add(measurement);
                _context.Measurements.Add(measurement);
            }
            else
            {
                //oven doesn't exist
                throw new ArgumentException("Oven with given id doesn't exist.");
            }
        }

        public void UpdateOven(Oven oven)
        {

        }

        public bool OvenExists(long ovenID)
        {
            return _context.Ovens.Any(o => o.OvenId == ovenID);
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
