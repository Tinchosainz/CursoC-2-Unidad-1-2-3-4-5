using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefono
{
    internal class Telefono
    {
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
        
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperdor;

        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico;}
            set { numeroTelefonico = value;}
        }
        public int CodigoOperador 
        {
            get { return codigoOperdor; }
            set { codigoOperdor = value;}
        }

        public string llamar()
        {
            return "Realizando Llamada";
        }
        public string llamar(string contacto)
        {
            return "Llamando a " + contacto + "...";
        }
    }
}
