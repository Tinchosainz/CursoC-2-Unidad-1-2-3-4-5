using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ruedas r1 = new Ruedas();
            r1.Año = 10;

            Console.WriteLine(r1.Año);

            Console.ReadKey();
        }
    }
}
