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
    public class BoatsController : VehicleControllerBase<Boat>
    {
        public BoatsController(IGenericVehicleRepository<Boat> genericVehicleRepository) : base(genericVehicleRepository)
        {

        }


    }
}
