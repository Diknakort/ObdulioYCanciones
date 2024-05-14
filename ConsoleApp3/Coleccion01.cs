using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    public class Coleccion01 : IColeccionVendible
    {
        public List<IVendible> elementoVenta
        {
            get => default;
            set
            {
            }
        }

        public double dameBeneficio()
        {
            throw new System.NotImplementedException();
        }

        public void add()
        {
            throw new System.NotImplementedException();
        }
    }
}