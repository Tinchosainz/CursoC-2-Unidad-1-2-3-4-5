using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad3
{
    internal class Muebles : Producto
    {
        private string tipoDeMadera;
        private int capacidadDeCarga;

        public string TipoDeMadera
        {
            get { return tipoDeMadera; }
            set { tipoDeMadera = value;}
        }
        public int CapacidadDeCarga
        {
            get { return capacidadDeCarga; }
            set { capacidadDeCarga = value; }
        }
    }
}
