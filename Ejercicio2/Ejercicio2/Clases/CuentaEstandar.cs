using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    class CuentaEstandar : Cuenta
    {
        public CuentaEstandar(int edad)
        {
            this.edad = edad;
            tipo = "Cuenta Estándar";
        }

        public override double CalcularInteres()
        {
            return 0.005;
        }

        public override string ObtenerRegalo()
        {
            return "No hay regalos disponibles";
        }
    }
}
