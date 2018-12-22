using MonoApp.Repository.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoApp.Repository.Common.Vehicle
{
    public interface IVehicleModelRepository
    {
        IEnumerable<IVehicleModel> GetAll();
        IVehicleModel GetById(int makeId);
        void Insert(IVehicleModel vehicleModels);
        void Delete(int makeId);
        void Update(IVehicleModel vehicleModels);
        void Save();
    }
}
