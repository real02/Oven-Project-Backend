using Microsoft.EntityFrameworkCore;
using OvenLibrary.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OvenLibrary.API.DbContexts
{
    public class OvensContext : DbContext
    {
        public OvensContext(DbContextOptions<OvensContext> options)
           : base(options)
        {
        }

        public DbSet<Oven> Ovens { get; set; }
        public DbSet<Measurement> Measurements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oven>().HasData(
                new Oven()
                {
                    OvenId = 1,
                    Address = "Krapinska 15",
                    LocationLatitude = 45.80423226706458,
                    LocationLongitude = 15.948932298011403,
                },
                new Oven()
                {
                    OvenId = 2,
                    Address = "Rooseveltov trg 5",
                    LocationLatitude = 45.80851277024695,
                    LocationLongitude = 15.966035138678405,
                }
            );
            modelBuilder.Entity<Measurement>().HasData(
                new Measurement()
                {
                    MeasurementId = 1,
                    OvenId = 1,
                    DateTime = new DateTime(2020, 8, 1, 0, 0, 0),
                    PowerConsumption = 2.29,
                    Temperature = 28
                },
                new Measurement()
                {
                    MeasurementId = 2,
                    OvenId = 1,
                    DateTime = new DateTime(2020, 8, 1, 3, 0, 0),
                    PowerConsumption = 2.33,
                    Temperature = 22
                },
                new Measurement()
                {
                    MeasurementId = 3,
                    OvenId = 1,
                    DateTime = new DateTime(2020, 8, 1, 6, 0, 0),
                    PowerConsumption = 3.4,
                    Temperature = 24
                },
                new Measurement()
                {
                    MeasurementId = 4,
                    OvenId = 1,
                    DateTime = new DateTime(2020, 8, 1, 9, 0, 0),
                    PowerConsumption = 3.4,
                    Temperature = 26
                },
                new Measurement()
                {
                    MeasurementId = 5,
                    OvenId = 1,
                    DateTime = new DateTime(2020, 8, 1, 12, 0, 0),
                    PowerConsumption = 3.1,
                    Temperature = 221
                },
                new Measurement()
                {
                    MeasurementId = 6,
                    OvenId = 1,
                    DateTime = new DateTime(2020, 8, 1, 15, 0, 0),
                    PowerConsumption = 3.2,
                    Temperature = 23
                },
                new Measurement()
                {
                    MeasurementId = 7,
                    OvenId = 1,
                    DateTime = new DateTime(2020, 8, 1, 18, 0, 0),
                    PowerConsumption = 2.4,
                    Temperature = 19
                },
                new Measurement()
                {
                    MeasurementId = 8,
                    OvenId = 1,
                    DateTime = new DateTime(2020, 8, 1, 21, 0, 0),
                    PowerConsumption = 3.0,
                    Temperature = 22
                },
                new Measurement()
                {
                    MeasurementId = 9,
                    OvenId = 1,
                    DateTime = new DateTime(2020, 8, 2, 0, 0, 0),
                    PowerConsumption = 3.4,
                    Temperature = 20
                },
                new Measurement()
                {
                    MeasurementId = 10,
                    OvenId = 2,
                    DateTime = new DateTime(2020, 8, 1, 0, 0, 0),
                    PowerConsumption = 2.29,
                    Temperature = 21
                },
                new Measurement()
                {
                    MeasurementId = 11,
                    OvenId = 2,
                    DateTime = new DateTime(2020, 8, 1, 3, 0, 0),
                    PowerConsumption = 2.33,
                    Temperature = 22
                },
                new Measurement()
                {
                    MeasurementId = 12,
                    OvenId = 2,
                    DateTime = new DateTime(2020, 8, 1, 6, 0, 0),
                    PowerConsumption = 3.4,
                    Temperature = 23
                },
                new Measurement()
                {
                    MeasurementId = 13,
                    OvenId = 2,
                    DateTime = new DateTime(2020, 8, 1, 9, 0, 0),
                    PowerConsumption = 3.4,
                    Temperature = 24
                },
                new Measurement()
                {
                    MeasurementId = 14,
                    OvenId = 2,
                    DateTime = new DateTime(2020, 8, 1, 12, 0, 0),
                    PowerConsumption = 3.4,
                    Temperature = 20
                },
                new Measurement()
                {
                    MeasurementId = 15,
                    OvenId = 2,
                    DateTime = new DateTime(2020, 8, 1, 15, 0, 0),
                    PowerConsumption = 3.4,
                    Temperature = 19
                },
                new Measurement()
                {
                    MeasurementId = 16,
                    OvenId = 2,
                    DateTime = new DateTime(2020, 8, 1, 18, 0, 0),
                    PowerConsumption = 3.4,
                    Temperature = 18
                },
                new Measurement()
                {
                    MeasurementId = 17,
                    OvenId = 2,
                    DateTime = new DateTime(2020, 8, 1, 21, 0, 0),
                    PowerConsumption = 3.4,
                    Temperature = 20
                },
                new Measurement()
                {
                    MeasurementId = 18,
                    OvenId = 2,
                    DateTime = new DateTime(2020, 8, 2, 0, 0, 0),
                    PowerConsumption = 3.4,
                    Temperature = 23
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
