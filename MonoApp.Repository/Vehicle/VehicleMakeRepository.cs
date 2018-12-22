using MonoApp.Repository.Common.Vehicle;
using MonoApp.Repository.Common.Model;
using MonoApp.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MonoApp.DAL.Interface;

namespace Project.Service.Repository
{
    public class VehicleMakeRepository : IVehicleMakeRepository
    {
        protected IDbContext DbContext { get; private set; }

        public VehicleMakeRepository(IDbContext context)
        {
            this.DbContext = context;
        }

        public IEnumerable<IVehicleMake> GetAll()
        {
            throw new NotImplementedException();
        }

        public IVehicleMake GetById(int makeId)
        {
            throw new NotImplementedException();
        }

        public void Insert(IVehicleMake vehicleMake)
        {
            throw new NotImplementedException();
        }

        public void Update(IVehicleMake vehicleMake)
        {
            throw new NotImplementedException();
        }

        public void Delete(int makeId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<IVehicleMake> Get(VehicleMakeRFilter filter)
        {

            if(filter.Name != null && filter.Name != "")
            {

            }

            if(filter.Id != Guid.Empty)
            {

            }

            return this.DbContext.VehicleMakes.Find();
        }

        class VehicleMakeRFilter
        {
            public Guid Id { get; set; }

            public string Name { get; set; }

            public string Abrv { get; set; }
        }

       
    }
}
