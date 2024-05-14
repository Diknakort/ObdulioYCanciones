using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Musica001
{
    public class Validador01 : IValidable
    {
        public bool isValid(IReproducible Elemento)
        {
            return (Elemento.duracion > 0);
        }
    }
}