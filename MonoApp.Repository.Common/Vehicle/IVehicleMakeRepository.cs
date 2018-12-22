using MonoApp.Repository.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoApp.Repository.Common.Vehicle
{
    public interface IVehicleMakeRepository
    {
        IEnumerable<IVehicleMake> GetAll();
        IVehicleMake GetById(int makeId);
        void Insert(IVehicleMake vehicleMake);
        void Delete(int makeId);
        void Update(IVehicleMake vehicleMake);
        void Save();
    }
}
