using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad3
{
    internal class Heladeras : Electrodomesticos
    {
        private int tempMin;
        private string color;

        public int TempMin
        {
            get { return tempMin; }
            set { tempMin = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
