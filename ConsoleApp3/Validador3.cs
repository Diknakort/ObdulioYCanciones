using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class Validador3 : Validador2, IValidable
    {
        public bool isValid(IVendible elemento)
        {
            return base.isValid(elemento) && elemento.PVP > 100;
        }
    }
}