using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Perro
    {
        private string raza;
        private string origen;
        private string nombre;

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public string Origen
        {
            get { return origen; }
            set { origen = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
