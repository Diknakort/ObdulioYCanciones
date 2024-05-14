using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public interface IVendible
    {
        double PVP { get; set; }
        double PrecioFabricacion { get; set; }
        double dameBeneficio();
    }
}