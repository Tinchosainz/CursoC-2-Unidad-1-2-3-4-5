using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = "Pepe";

            Console.WriteLine(a1.ToString());
            
            Gato g1 = new Gato();
            g1.Nombre = "Juan";
            Console.WriteLine(g1.comunicarse()); 
            
            Perro p1 = new Perro();
            p1.Nombre = "Negrito";
            Console.WriteLine(p1.comunicarse());

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(a1);
            animales.Add(new Pez());
            animales.Add(new Canario());


            List<flyable> listaVoladores = new List<flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());   

            Animal a2 = g1;
            Gato g8 = (Gato)a2;

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }




            Console.ReadKey();
        }
    }
}
