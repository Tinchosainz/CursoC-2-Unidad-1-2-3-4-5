using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales
            //If
            //Switch

            int a = 10;
            int b = 12;
            // == != < > <= >=
            // ! && || (alt + 124)
            if(a == b && b != 10 || !(a == 20) )
            {
                Console.WriteLine("Bien");
            }
            else if ( a == 254)
            {
                Console.WriteLine("Mal");
            }
            else if (a < 10)
            {
                Console.WriteLine("Mal 2");
            }
            else
            {
                Console.WriteLine("Mal 3");
            }

            switch (a)
            {
                case 1:
                    // cosas
                    break;
                case 2:
                    // cosas
                    break;
                default:
                    // cosas
                    break;
            }

        }
    }
}
