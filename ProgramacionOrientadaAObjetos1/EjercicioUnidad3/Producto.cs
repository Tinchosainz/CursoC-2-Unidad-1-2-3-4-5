using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioUnidad3
{
    internal class Producto
    {
        private int codigoProducto;
        private int ancho;
        private int largo;
        private int profundo;

        public int CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
        }
        public int Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public int Largo
        {   
            get { return largo; } 
            set { largo = value; } 
        }
        public int Profundo
        {
            get { return profundo; }
            set { profundo = value; }
        }
    }
}

