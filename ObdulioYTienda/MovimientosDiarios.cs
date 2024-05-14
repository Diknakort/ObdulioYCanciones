using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public class MovimientosDiarios : IColeccionVendibles
    {
        List<IVendible> vendibles = new List<IVendible>();
        int numOrdenadores = 0;
        int numOrdenadoresMas125 = 0;
        int ordenadorMasBarato = Int32.MaxValue;
        int ordenadorMasCaro = 0;
        int totalPrecio = 0;
        public void Add(IVendible elemento)
        {
            vendibles.Add(elemento);
            numOrdenadores++;
            totalPrecio += elemento.Precio;
            if (elemento.Precio > 125)
            {
                numOrdenadoresMas125++;
            }
            if (elemento.Precio < ordenadorMasBarato)
            {
                ordenadorMasBarato = elemento.Precio;
            }
            if (elemento.Precio > ordenadorMasCaro)
            {
                ordenadorMasCaro = elemento.Precio;
            }
       }
        public void Listar()
        {
            foreach (var item in vendibles)
            {
                Console.WriteLine(item);
            }
        }

        public int NumeroOrdenadoresVendidos()
        {
            return numOrdenadores;
        }

        public int OrdenadoresDeMasde125()
        {
            return numOrdenadoresMas125;
        }

        public int OrdenadorMasBarato()
        {
            return ordenadorMasBarato;
        }

        public int OrdenadorMasCaro()
        {
            return ordenadorMasCaro;
        }

        public double PrecioMedioOrdenador()
        {
            return totalPrecio / numOrdenadores;
        }

        public double TotalImporteFacturado()
        {
            return totalPrecio;
        }
    }
}