using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleControl.API.Entities;
using VehicleManagement.API.Repositories;

namespace VehicleManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : VehicleControllerBase<Bus>
    {
        public BusesController(IGenericVehicleRepository<Bus> genericVehicleRepository) : base(genericVehicleRepository)
        {

        }

    }
}
