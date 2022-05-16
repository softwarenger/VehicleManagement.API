using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleManagement.API.Models
{
    public interface IColor
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
    }
}
