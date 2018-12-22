using System;
using System.Collections.Generic;
using System.Text;

namespace MonoApp.Model.Common.Model
{
    public interface IVehicleModel
    {
        Guid Id { get; set; }
        int MakeId { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }
    }
}
