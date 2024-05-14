using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class JarronPorcelana : IVendible
    {
        public double PVP { get; set; } = 200;
        public double PrecioFabricacion { get; set; } = 150;

        public double dameBeneficio()
        {
            return this.PVP - this.PrecioFabricacion;
        }
    }
}