using Project.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.Interfaces.Repository
{
    interface IVehicleModelRepository
    {
        List<VehicleModel> GetVehicleModels();
    }
}
