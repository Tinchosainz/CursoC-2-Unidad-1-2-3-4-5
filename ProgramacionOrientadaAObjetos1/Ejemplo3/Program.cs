using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            nombre = "Hola como estas";
            int cant = nombre.Length;
            nombre = nombre.ToUpper();
            nombre = nombre.ToLower();
            nombre = nombre.Replace('a', 'v');

            Console.WriteLine(nombre);
            Console.ReadKey();
        }
    }
}
