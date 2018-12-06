using Project.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service
{
    public class VehicleRepository
    {
        public List<VehicleMake> GetVehicleMakes()
        {
            VehicleDBContext vehicleDBContext = new VehicleDBContext();
            return vehicleDBContext.VehicleMakes.ToList()
        }

        public List<VehicleModel> GetVehicleModels()
        {
            VehicleDBContext vehicleDBContext = new VehicleDBContext();
            return vehicleDBContext.VehicleModels.ToList();
        }
    }
}
