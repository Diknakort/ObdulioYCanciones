using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public class ValidadorPositivo : IValidador
    {
        public bool isValid(IVendible ElementoVenta)
        {
            return (ElementoVenta.Precio > 0 && ElementoVenta.Garantia > 0);
        }
    }
}