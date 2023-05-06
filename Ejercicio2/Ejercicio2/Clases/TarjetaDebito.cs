using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    class TarjetaDebito : Producto
    {
        public TarjetaDebito(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public override void MostrarDetalle()
        {
            Console.WriteLine("Tarjeta de Debito: " + nombre);
            Console.WriteLine("Precio: Gratuita");
        }
    }
}
