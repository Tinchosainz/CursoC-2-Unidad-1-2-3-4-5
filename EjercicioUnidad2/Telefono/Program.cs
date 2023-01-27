using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("Iphone 12", "Apple");

            Console.WriteLine("Escriba numero telefonico");
            t1.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("Escriba Codigo de operador (1, 2 o 3)");
            t1.CodigoOperador = int.Parse(Console.ReadLine());
            if(t1.CodigoOperador != 1 && t1.CodigoOperador != 2 && t1.CodigoOperador != 3)
            {
                Console.WriteLine("Esta mal el codigo de operador");
            }
            else
            {
                Console.WriteLine("La marca del telefono es " + t1.Marca + ", modelo " + t1.Modelo);
                Console.WriteLine("¿A quien quiere llamar?");
                //string contacto = Console.ReadLine();
                //Console.WriteLine(t1.llamar(contacto));
                Console.WriteLine(t1.llamar(Console.ReadLine()));
            }
          
            Console.ReadKey();
        }
        
    }
}
