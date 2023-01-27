using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad3
{
    internal class Placard : Muebles
    {
        private int cantidadDeCajones;
        private string color;

        public int CantidadDeCajones
        {
            get { return cantidadDeCajones; }
            set { cantidadDeCajones = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
