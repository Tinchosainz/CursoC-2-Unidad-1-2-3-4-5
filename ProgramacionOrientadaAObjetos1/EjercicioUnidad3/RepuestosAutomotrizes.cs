using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad3
{
    internal class RepuestosAutomotrizes : Producto
    {
        private string modelo;
        private int año;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int Año
        {
            get { return año; }
            set { año = value; }
        }
    }
}
