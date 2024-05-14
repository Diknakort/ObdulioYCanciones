using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public interface IVendible
    {
        int Precio { get; set; }
        int Garantia { get; set; }
        double TiempoMedio();
    }
}