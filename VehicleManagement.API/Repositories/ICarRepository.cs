using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleControl.API.Entities;

namespace VehicleManagement.API.Repositories
{
    public interface ICarRepository : IGenericVehicleRepository<Car>
    {

        public bool OpenLight(Guid carId);
        public bool CloseLight(Guid carId);

        public void DeleteCar(Guid carId);


    }
}
