using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi1 = new Taxi();
            Taxi taxi2 = new Taxi();
            taxi2.SetMatricula("TAX-002");
            taxi2.SetNumeroLicencia("12345678900000");

            Autobus autobus1 = new Autobus();
            Autobus autobus2 = new Autobus();
            autobus2.SetMatricula("BUS-002");
            autobus2.SetNumeroPlazas(50);

            Vehiculo[] flota = { taxi1, taxi2, autobus1, autobus2 };


            foreach (Vehiculo vehiculo in flota)
            {
                Console.WriteLine(vehiculo.MostrarDatos());
                Console.WriteLine(vehiculo.TipoVehiculo());
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
