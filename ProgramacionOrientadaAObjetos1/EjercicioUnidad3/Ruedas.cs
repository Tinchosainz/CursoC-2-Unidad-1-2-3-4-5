using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad3
{
    internal class Ruedas : RepuestosAutomotrizes
    {
        private int diametro;
        private int rodado;

        public int Diametro
        {
            get { return diametro; }
            set { diametro = value; }
        }
        public int Rodado
        {
            get { return rodado; }
            set { rodado = value; }
        }
    }
}
