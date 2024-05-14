using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public class FabricaJacinto : IFabricaVendibles
    {
        public IValidador Validador { get; set; }

        public IVendible DameVendible(TipoOrdenador tipo, int precio=0, int garantia = 0)
        {
            IVendible vendible = null;
            switch (tipo)
            {
                case TipoOrdenador.Lentorro: vendible = new Lentorro();break;
                case TipoOrdenador.Normal: vendible = new Normal();break;
                case TipoOrdenador.Gamer: vendible = new Gamer();break;
            }
            if (precio != 0 && vendible != null)
                vendible.Precio = precio;
            if (garantia != 0 && vendible != null)
                vendible.Garantia = garantia;

            if (vendible!=null) 
            {
                if (Validador.isValid(vendible))
                {
                    return vendible;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }
    }
}