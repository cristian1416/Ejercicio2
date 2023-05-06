using Ejercicio2.Clases;
using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Cuenta cuenta1 = new CuentaJoven(20);
            Console.WriteLine(cuenta1.tipo); // Cuenta Joven
            Console.WriteLine(cuenta1.CalcularInteres()); // 0.02
            Console.WriteLine(cuenta1.ObtenerRegalo()); // Cd Música

            Cuenta cuenta2 = new Cuenta10(35);
            Console.WriteLine(cuenta2.tipo); // Cuenta 10
            Console.WriteLine(cuenta2.CalcularInteres()); // 0.01
            Console.WriteLine(cuenta2.ObtenerRegalo()); // Reproductor CD

            Cuenta cuenta3 = new CuentaOro(70);
            Console.WriteLine(cuenta3.tipo); // Cuenta Oro
            Console.WriteLine(cuenta3.CalcularInteres()); // 0.015
            Console.WriteLine(cuenta3.ObtenerRegalo()); // Tarjeta de Crédito gratuita

            Cuenta cuenta4 = new CuentaEstandar(50);
            Console.WriteLine(cuenta4.tipo); // Cuenta Estándar
            Console.WriteLine(cuenta4.CalcularInteres()); // 0.005
            Console.WriteLine(cuenta4.ObtenerRegalo()); // No hay regalos disponibles



            // Uso de las subclases de Producto
            TarjetaDebito tarjeta1 = new TarjetaDebito("Tarjeta de Débito Joven", 0);
            tarjeta1.MostrarDetalle(); // Tarjeta de Débito: Tarjeta de Débito Joven \n Precio: 0 pesos

            TarjetaDebito tarjeta2 = new TarjetaDebito("Tarjeta de Débito 10", 0);
            tarjeta2.MostrarDetalle(); // Tarjeta de Débito: Tarjeta de Débito 10 \n Precio: 0 pesos

            TarjetaCredito tarjeta3 = new TarjetaCredito("Tarjeta de Crédito Oro");
            tarjeta3.MostrarDetalle(); // Tarjeta de Crédito: Tarjeta de Crédito Oro \n Precio: Gratuita

            Regalo regalo1 = new Regalo("Cd Música", 1800000);
            regalo1.MostrarDetalle(); // Regalo: Cd Música \n Precio: 1800000 pesos

            Regalo regalo2 = new Regalo("Reproductor CD", 0);
            regalo2.MostrarDetalle(); // Regalo: Reproductor CD \n Precio: 0 pesos
        }
    }
}

