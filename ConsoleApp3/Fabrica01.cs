using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class Fabrica01 : IFabricaVendible
    {
        public int validador { get ; set ; }

        public Fabrica01 (IValidable Validador)
        {
            this.Validador = Validador;
        }
        public IVendible dameInstancia(string tipo)
        {
            switch(tipo)
            {
                case EnumTipoVendible.JarronMing: vendible = new JarronMing();break;
                default: vendible = new JarronPorcelana(); break;
            }
            if (Validador.isValid())
            {

            }
        }
    }
}