using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Aguila : AnimalSalvaje, flyable
    {
        public string volar()
        {
            return "vuela vuela aguila";
        }
    }
}
