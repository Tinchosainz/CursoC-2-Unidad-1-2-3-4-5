using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad3
{
    internal class Cafeteras : Electrodomesticos
    {
        private string tipoDeCafe;
        private int capacidadDeProduccion;

        public string TipoDeCafe
        {
            get { return tipoDeCafe; }
            set { tipoDeCafe = value; }
        }
        public int CapacidadDeProduccion
        {
            get { return capacidadDeProduccion; }
            set { capacidadDeProduccion = value; }
        }
    }
}
