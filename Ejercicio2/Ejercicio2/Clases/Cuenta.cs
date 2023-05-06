using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    abstract class Cuenta
    {
        protected int edad;
        public string tipo;

        public abstract double CalcularInteres();
        public abstract string ObtenerRegalo();
    }
}
