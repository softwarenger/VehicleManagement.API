using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleControl.API.Entities;
using VehicleManagement.API.Models;

namespace VehicleManagement.API.Repositories
{
    public class GenericVehicleRepository<TEntity> : IGenericVehicleRepository<TEntity>
        where TEntity : class, IVehicle, new()
    {
        private readonly VehicleContext _context;
        public GenericVehicleRepository(VehicleContext context)
        {
            _context = context;
        }
        public List<TEntity> GetByColorId(Guid colorId)
        {
            return _context.Set<TEntity>().Where(vehicle => vehicle.ColorId == colorId).ToList();

        }

        public List<TEntity> GetByColorText(string text)
        {
            return _context.Set<TEntity>().Include("Color").Where(vehicle => vehicle.Color.Text.ToLower() == text.ToLower()).ToList();
        }
    }
}
