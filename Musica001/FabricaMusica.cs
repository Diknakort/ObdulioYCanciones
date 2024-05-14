using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;

namespace Musica001
{
    public class FabricaMusica : IFabricaMusica
    {
        public IValidable Validador { get; set; }
        public FabricaMusica(IValidable Validador)
        {
            this.Validador = Validador;
        }

        public string nombre { get; set; }
        public double duracion { get; set; }

        public IReproducible dameReproducible(EnumTipoReproducible tipo)
        {
            IReproducible reproducible = null;
            switch (tipo)
            {
                case EnumTipoReproducible.Canciones: reproducible = new Canciones(); break;
                case EnumTipoReproducible.VideoClip: reproducible = new VideoClip(); break;
                default: reproducible = new Podcast(); break;
            }
            if (Validador.isValid(reproducible))
            {
                return reproducible;
            }
            else {
                return null;
            }
        }

        IReproducible IFabricaMusica.DameReproducible(EnumTipoReproducible tipo, double duracion)
        {
            IReproducible reproducible = null;
            switch (tipo)
            {
                case EnumTipoReproducible.Canciones: reproducible = new Canciones() { duracion = duracion }; break;
                case EnumTipoReproducible.VideoClip: reproducible = new VideoClip() { duracion = duracion }; break;
                default: reproducible = new Podcast() { duracion = duracion }; break;
            }
            if (Validador.isValid(reproducible))
            {
                return reproducible;
            }
            else
            {
                return null;
            }
        }
    }
}