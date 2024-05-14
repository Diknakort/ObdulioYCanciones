using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Musica001
{
    public class Podcast : IReproducible
    {
        public double duracion { get ; set ; }

        public double dameDuracion()
        {
            throw new NotImplementedException();
        }
    }
}