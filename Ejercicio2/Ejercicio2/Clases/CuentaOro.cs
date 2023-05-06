using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    class CuentaOro : Cuenta    
    {
        public CuentaOro(int edad)
        {
            this.edad = edad;
            tipo = "Cuenta Oro";
        }

        public override double CalcularInteres()
        {
            return 0.015;
        }

        public override string ObtenerRegalo()
        {
            return "Tarjeta de Crédito gratuita";
        }
    }
}
