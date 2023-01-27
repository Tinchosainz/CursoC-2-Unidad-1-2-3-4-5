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
            //Primer lote con 10 registros de productos, cada producto tiene:
            //- Codigo de Articulo(3 digitos no correlativos)
            //- Precio
            //- Codigo de Marca (1 a 10)
            //Segundo lote con las ventas de la semana. Cada venta tiene:
            //- Codigo de Articulo
            //- Cantidad
            //- Codigo Cliente ( 1 a 100)
            //Este lote corta con Codigo de Cliente 0.
            
            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los datos del producto");
                Console.WriteLine("Codigo");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio");
                articulos[x].Precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Marca 1 a 10");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta");
            Console.WriteLine("Codigo de Cliente");
            venta.CodigoCliente= int.Parse(Console.ReadLine());
           
            while (venta.CodigoCliente != 0)
            {  
                Console.WriteLine("Codigo");
                venta.CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad");
                venta.Cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la venta");
                Console.WriteLine("Codigo de Cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
