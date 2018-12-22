﻿using MonoApp.Model.Common.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoApp.DAL.Models
{
    public class VehicleModel : IVehicleModel
    {
        public Guid Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}
