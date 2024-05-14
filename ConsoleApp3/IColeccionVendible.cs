using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public interface IColeccionVendible
    {
        double dameDineros();
        double dameCoste();
        double dameVenta();
        double dameBeneficio();
        bool Add(IVendible elemento);
    }
}