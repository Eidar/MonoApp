using Project.Service.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Interfaces.DBContext
{
    interface IVehicleModelDBContext
    {
        DbSet<VehicleModel> VehicleModels { get; set; }
    }
}
