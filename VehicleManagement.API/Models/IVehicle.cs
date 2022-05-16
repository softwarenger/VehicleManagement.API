using System;
using VehicleManagement.API.Entities;

namespace VehicleManagement.API.Models
{
    public interface IVehicle
    {
        public Guid Id { get; set; }
        public Guid ColorId { get; set; }
        public Color Color { get; set; }
    }
}
