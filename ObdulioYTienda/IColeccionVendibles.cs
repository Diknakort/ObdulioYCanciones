using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObdulioYTienda
{
    public interface IColeccionVendibles
    {
        double TotalImporteFacturado();
        int NumeroOrdenadoresVendidos();
        int OrdenadorMasBarato();

        int OrdenadorMasCaro();

        double PrecioMedioOrdenador();

        int OrdenadoresDeMasde125();

        void Listar();
        public void Add(IVendible elemento);
    }
}