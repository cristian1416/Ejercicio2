using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    class CuentaJoven : Cuenta
    {
        public CuentaJoven(int edad)
        {
            this.edad = edad;
            tipo = "Cuenta Joven";
        }

        public override double CalcularInteres()
        {
            return 0.02;
        }

        public override string ObtenerRegalo()
        {
            return "Cd Música";
        }
    }
}
