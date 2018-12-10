﻿using Project.Service.DBContext;
using Project.Service.Interfaces.Repository;
using Project.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Repository
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        List<VehicleModel> IVehicleModelRepository.GetVehicleModels()
        {
            VehicleDBContext vehicleDBContext = new VehicleDBContext();
            return vehicleDBContext.VehicleModels.ToList();
        }
    }
}

