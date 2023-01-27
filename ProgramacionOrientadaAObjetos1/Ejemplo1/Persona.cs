using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        //Persona: edad, sueldo, nombre.
        // Atributos 
        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(String nombre)
        {
            this.nombre = nombre;
        }
        
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        //Metodos
        public string saludar()
        {
            return "Hola soy " + nombre;
        }

        public string saludar(string personaje)
        {
            return "Hola " + personaje + ", soy " + nombre;
        }
    }
}
