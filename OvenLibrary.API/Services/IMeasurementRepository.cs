using OvenLibrary.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Services
{
    public interface IMeasurementRepository
    {
        IEnumerable<Measurement> GetMeasurements();
        Measurement GetMeasurement(Int64 measurementID);
        void AddMeasurement(Measurement measurement);
        void DeleteMeasurement(Measurement measurement);
        bool Save();
    }
}
