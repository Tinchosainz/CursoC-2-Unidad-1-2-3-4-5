﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime fecha = new DateTime(2204, 4, 1);
            DateTime fecha = DateTime.Now;

            Console.WriteLine("La fecha es " + fecha.ToString());

            Console.ReadKey();
        }
    }
}
