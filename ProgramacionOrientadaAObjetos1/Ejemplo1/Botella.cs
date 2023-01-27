using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {   
        //Constructor
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual= 0;
        }
        // sobrecarga de constructor
        public Botella() { }

        //Destructor
        ~Botella()
        {

        }

        //Botella: Capacidad, Color, Material

        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }
        
        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        public string Material
        {
            get { return material; }
        }

        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}

        //Metodo
        public float recargar()
        {
            cantidadActual = 100;
            if(cantidadActual > 0)
            {
                int dif = 100 - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            return 50;
        }

        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
        }
    }
}
