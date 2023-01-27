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
            //int edad;
            //float sueldo;
            //string nombre;
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            Persona p1 = new Persona("PEPE");
            p1.setEdad(20);
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("MAXI"));
            Console.WriteLine("La edad es " + p1.getEdad());

            Botella b1 = new Botella("Rojo", "Plastico");
            //b1.Capacidad = 200;
            //string algo2 = b1.Material;
            //int algo = b1.Capacidad;

            //Botella b2 = new Botella();
            
            Console.WriteLine("Capacidad Botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar la cantidad actual es " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar la cantidad actual es " + b1.CantidadActual);


            Console.ReadKey();

            //Perro p1 = new Perro();
            //Console.WriteLine("escriba el nombre del perro");
            //p1.Nombre = Console.ReadLine();
            //Console.WriteLine("escriba la raza del perro");
            //p1.Raza = Console.ReadLine();
            //Console.WriteLine("escriba el origen del perro");
            //p1.Origen = Console.ReadLine();

            //string Nombre = p1.Nombre;
            //string Origen = p1.Origen;
            //string Raza = p1.Raza;
            //Console.WriteLine("el perro se llama " + Nombre + " es de " + Origen + " y es un " + Raza);
            //Console.ReadKey();
        }
    }
}
