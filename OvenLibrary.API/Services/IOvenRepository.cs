using OvenLibrary.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.Services
{
    public interface IOvenRepository
    {
        IEnumerable<Oven> GetOvens();
        Oven GetOven(Int64 ovenID);
        ICollection<Measurement> GetMeasurements(Int64 ovenId);
        void AddOven(Oven oven);
        void DeleteOven(Oven oven);
        void UpdateOven(Oven oven);
        void AddMeasurement(Int64 ovenId, Measurement measurement);
        bool Save();
    }
}
