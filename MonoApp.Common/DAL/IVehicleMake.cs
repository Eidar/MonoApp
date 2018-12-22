using System;
using System.Collections.Generic;
using System.Text;

namespace MonoApp.Common.Model
{
    public interface IVehicleMake
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
    }
}
