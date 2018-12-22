using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MonoApp.DAL.Models;
using MonoApp.DAL.Interface;

namespace MonoApp.DAL.DBContext
{
    public class VehicleDBContext : DbContext, IDbContext
    { 
        public DbSet<VehicleMake> VehicleMakes { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
    }
}
