using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.API.Entities;

namespace VehicleManagement.API.Models
{
    public class Vehicle :IVehicle
    {
        public Guid Id { get; set; }
     
        public Guid ColorId { get; set; }

        public Color Color { get; set; }
    }
}
