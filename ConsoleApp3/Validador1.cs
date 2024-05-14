using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp3
{
    public class Validador1 : IValidable
    {
        public bool isValid(IVendible Elemento)
        {
            return Elemento.PrecioFabricacion > 0 && Elemento.PVP > 0;
        }
    }
}