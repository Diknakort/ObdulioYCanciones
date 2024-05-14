using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class JarronMing : IVendible
    {
        public double PVP { get; set; } = 10000;
        public double PrecioFabricacion { get; set; } = 7000;

        public double dameBeneficio()
        {
            return this.PVP - this.PrecioFabricacion;
        }

        public static implicit operator JarronMing(JarronPorcelana v)
        {
            throw new NotImplementedException();
        }
    }
}