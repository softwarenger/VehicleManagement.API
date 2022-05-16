using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.API.Entities;
using VehicleManagement.API.Models;

namespace VehicleManagement.API.Repositories
{
    public interface IGenericVehicleRepository<TEntity> where TEntity : class, IVehicle, new()
    {
        public List<TEntity> GetByColorId(Guid colorId);
        public List<TEntity> GetByColorText(string text);

    }
}
