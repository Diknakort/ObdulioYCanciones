using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Musica001
{
    public interface IColeccionDistribucion
    {
        void Listar();
        int numeroCanciones();
        double totalDuracion();
        bool Add(IReproducible elemento);
    }
}