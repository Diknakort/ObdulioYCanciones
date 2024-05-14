using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public class Lentorro : IVendible
    {
        public int Precio { get; set; } = 100;
        public int Garantia { get; set; } = 2;

        public double TiempoMedio()
        {
            return Precio / Garantia;
        }
        public override string ToString()
        {
            return $"Lentorro,{Precio},{Garantia},{TiempoMedio()}";
        }
    }
}