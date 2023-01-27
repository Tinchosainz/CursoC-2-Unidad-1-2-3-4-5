using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Auto : Vehiculo
    {
        public Auto()
        {
            Chasis = new Chasis();
        }
        public int Año { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        //composicion
        public string Chasis { get; set; }

        //agregacion
        public Motor Motor { get; set; }
    }
}
