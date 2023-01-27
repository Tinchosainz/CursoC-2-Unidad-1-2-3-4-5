using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad3
{
    internal class Electrodomesticos : Producto
    {
        private int voltaje;
        private string tipoDeCarga;

        public int Voltaje
        {
            get { return voltaje; }
            set { voltaje = value; }
        }
        public string TipoDeCarga
        {
            get { return tipoDeCarga; }
            set { tipoDeCarga = value; }
        }
    }
}
