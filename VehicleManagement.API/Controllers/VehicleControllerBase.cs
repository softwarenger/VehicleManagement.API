using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.API.Models;
using VehicleManagement.API.Repositories;

namespace VehicleManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleControllerBase<TEntity> : ControllerBase
        where TEntity : class, IVehicle, new()
    {
        private IGenericVehicleRepository<TEntity> genericVehicleRepository;

        public VehicleControllerBase(IGenericVehicleRepository<TEntity> genericVehicleRepository)
        {
            this.genericVehicleRepository = genericVehicleRepository;
        }

        [HttpGet("GetByColorId")]
        public List<TEntity> GetByColorId(Guid colorId)
        {
            return genericVehicleRepository.GetByColorId(colorId);

        }

        [HttpGet("GetByColorText")]
        public List<TEntity> GetByColorText(string text)
        {
            return genericVehicleRepository.GetByColorText(text);
        }
    }
}
