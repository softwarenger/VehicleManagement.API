using VehicleManagement.API.Models;

namespace VehicleControl.API.Entities
{
    public class Car : Vehicle, ICar
    {
        public int Wheel { get; set; }
        public bool IsLightOpen { get; set; }
    }
}
