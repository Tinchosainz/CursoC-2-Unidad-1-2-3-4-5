using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funciones
            Console.WriteLine(saludar("Maxi"));
            Console.ReadKey();
        }
        static int sumar(int a , int b)
        {
            return a + b;
        }
        static string saludar(string nombre)
        {
            return "Hola" + nombre;
        }
    }
}
