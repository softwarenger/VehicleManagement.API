using Microsoft.AspNetCore.Mvc;
using System;
using VehicleControl.API.Entities;
using VehicleManagement.API.Repositories;

namespace VehicleManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : VehicleControllerBase<Car>
    {
        private ICarRepository carRepository;

        public CarsController(ICarRepository carRepository) : base(carRepository)
        {
            this.carRepository = carRepository;
        }
        [HttpPost("openlight")]
        public bool OpenLight(Guid carId)
        {
            return carRepository.OpenLight(carId);
        }
        [HttpPost("closelight")]
        public bool CloseLight(Guid carId)
        {
            return carRepository.CloseLight(carId);
        }

        [HttpDelete("deletecar")]
        public bool DeleteCar(Guid carId)
        {
            carRepository.DeleteCar(carId);
            return true;
        }


    }
}
