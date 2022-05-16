using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleControl.API.Entities;

namespace VehicleManagement.API.Repositories
{
    public class CarRepository : GenericVehicleRepository<Car>, ICarRepository
    {
        private readonly VehicleContext context;

        public CarRepository(VehicleContext context) : base(context)
        {
            this.context = context;
        }

        public bool CloseLight(Guid carId)
        {
            Car car = GetCarById(carId);
            if (car != null)
            {
                car.IsLightOpen = false;
                context.Update(car);
                return true;
            }
            return false;
        }

        private Car GetCarById(Guid carId)
        {
            return context.Cars.Where(car => car.Id == carId).FirstOrDefault();
        }

        public bool OpenLight(Guid carId)
        {
            Car car = GetCarById(carId);
            if (car != null)
            {
                car.IsLightOpen = true;
                context.Update(car);
                return true;
            }
            return false;
        }

        public void DeleteCar(Guid carId)
        {
            context.Cars.Remove(GetCarById(carId));
            context.SaveChanges();
            
        }
    }
}
