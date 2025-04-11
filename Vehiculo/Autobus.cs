using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Autobus : Vehiculo
    {
        private int numeroPlazas;

        public Autobus()
        {
            SetMatricula("BUS-001");
            SetModelo("VOLSKWAGEN");
            SetPotenciaCV(180.0);
            this.numeroPlazas = 40;
        }

        public int GetNumeroPlazas() => numeroPlazas;
        public void SetNumeroPlazas(int numeroPlazas) => this.numeroPlazas = numeroPlazas;

        public override string MostrarDatos()
        {
            return $"Autobús: {GetModelo()}, Matrícula: {GetMatricula()}, Potencia: {GetPotenciaCV()} CV, Plazas: {numeroPlazas}";
        }

        public override string TipoVehiculo()
        {
            return "Autobus";
        }
    }
}
