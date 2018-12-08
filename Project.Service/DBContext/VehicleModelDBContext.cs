﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Project.Service.Models;
using Project.Service.Interfaces.DBContext;

namespace Project.Service.DBContext
{
    public class VehicleModelDBContext : DbContext, IVehicleModelDBContext
    {
        public DbSet<VehicleModel> VehicleModels { get; set; }
    }
}
