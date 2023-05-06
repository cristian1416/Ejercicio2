using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    abstract class Producto
    {
        protected string nombre;
        protected double precio;

        public abstract void MostrarDetalle();
    }
}
