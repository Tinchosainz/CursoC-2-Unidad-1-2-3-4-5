using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    abstract internal class Persona //sealed (fin de herencia) / abstract (no se puede crear un new)
                                    // static (no hace falta crearla para usarla tmp puede heredar ni crear)
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
    }
}
