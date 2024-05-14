using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public interface IFabricaVendible
    {
        int validador { get; set; }

        IVendible dameInstancia(string tipo);
        IVendible dameInstancia(EnumTipoVendible jarronPorcelana);
    }
}