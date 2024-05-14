using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Musica001
{
    public interface IFabricaMusica
    {
        string nombre { get; set; }
        double duracion { get; set; }

        IReproducible DameReproducible(EnumTipoReproducible tipo, double duracion = 0);
    }
}