using Project.Service.Interfaces.Repository;
using Project.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Repository
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        List<VehicleMake> IVehicleMakeRepository.GetVehicleMakes()
        {
            VehicleMakeDBContext vehicleDBContext = new VehicleMakeDBContext();
            return vehicleDBContext.VehicleMakes.ToList();
        }
    }
}
