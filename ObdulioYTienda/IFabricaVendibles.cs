using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public interface IFabricaVendibles
    {
        IValidador Validador { get; set; }
        IVendible DameVendible(TipoOrdenador tipo, int precio=0, int garantia = 0);
    }
}