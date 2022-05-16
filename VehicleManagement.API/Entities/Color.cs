using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.API.Models;

namespace VehicleManagement.API.Entities
{
    public class Color:IColor
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

    }
}
