using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    class Cuenta10 : Cuenta
    {
        public Cuenta10(int edad)
        {
            this.edad = edad;
            tipo = "Cuenta 10";
        }

        public override double CalcularInteres()
        {
            return 0.01;
        }

        public override string ObtenerRegalo()
        {
            return "Reproductor CD";
        }
    }
}
