using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagement.API.Models
{
    public interface ICar : IVehicle
    {
        public int Wheel { get; set; }
        public bool IsLightOpen { get; set; }
    }
}
