using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    class TarjetaCredito:Producto
    {
        public TarjetaCredito(string nombre)
        {
            this.nombre = nombre;
            precio = 0;
        }
        public override void MostrarDetalle()
        {
            Console.WriteLine("Tarjeta de Crédito: " + nombre);
            Console.WriteLine("Precio: Gratuita");
        }
    }
}
