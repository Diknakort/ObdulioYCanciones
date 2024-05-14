using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Musica001
{
    public interface IValidable
    {
        bool isValid(IReproducible Elemento);
    }
}