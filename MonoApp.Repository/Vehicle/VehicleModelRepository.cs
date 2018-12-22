using MonoApp.Repository.Common.Model;
using MonoApp.Repository.Common.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoApp.DAL.Interface;

namespace Project.Service.Repository
{
    public class VehicleModelRepository : IVehicleModelRepository
    {
        protected IDbContext DbContext { get; private set; }

        public VehicleModelRepository(IDbContext context)
        {
            this.DbContext = context;
        }

        public IEnumerable<IVehicleModel> GetStudents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IVehicleModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IVehicleModel GetById(int makeId)
        {
            throw new NotImplementedException();
        }

        public void Insert(IVehicleModel vehicleModels)
        {
            throw new NotImplementedException();
        }

        public void Delete(int makeId)
        {
            throw new NotImplementedException();
        }

        public void Update(IVehicleModel vehicleModels)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

