using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Musica001
{
    public class ColeccionDistribucion01 : IColeccionDistribucion
    {
        List<IReproducible> reproducible = new List<IReproducible>();
        public double duracion = 0;
        public int numCanciones = 0;
        public double duracionTotal = 0;

        bool IColeccionDistribucion.Add(IReproducible elemento)
        {
            if (elemento != null)
            {
                reproducible.Add(elemento);
                numCanciones++;
                duracionTotal += elemento.duracion;
                return true;
            }
            return false;
        }
        public void Listar()
        {
            foreach (var item in reproducible)
            {
                Console.WriteLine(item);
            }
        }
        public int numeroCanciones()
        {
            return this.numCanciones;
        }

        public double totalDuracion()
        {
            return this.duracionTotal;
        }
    }
}