using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public interface IValidador
    {
        bool isValid(IVendible ElementoVenta);
    }
}