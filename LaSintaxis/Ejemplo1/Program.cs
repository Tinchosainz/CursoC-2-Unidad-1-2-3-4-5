using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            //int float bool char
            //double decimal long short string datetime
            Console.WriteLine("Ingrese un Numero");

            int a, b, c;
            float f;    
            
            a = int.Parse(Console.ReadLine());
            b = 20;
            c = b + a;
            Console.WriteLine("El resultado es " + c);
            Console.ReadKey();
        }
    }
}