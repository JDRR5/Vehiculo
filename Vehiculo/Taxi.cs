using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class Taxi : Vehiculo
    {
        private string numeroLicencia;

        public Taxi()
        {
            SetMatricula("TAX-001");
            SetModelo("KIA PICANTO");
            SetPotenciaCV(90.0);
            this.numeroLicencia = "586974389562";
        }

        public string GetNumeroLicencia() => numeroLicencia;
        public void SetNumeroLicencia(string numeroLicencia) => this.numeroLicencia = numeroLicencia;

        public override string MostrarDatos()
        {
            return $"Taxi: {GetModelo()}, Matrícula: {GetMatricula()}, Potencia: {GetPotenciaCV()} CV, Licencia: {numeroLicencia}";
        }

        public override string TipoVehiculo()
        {
            return "Taxi";
        }
    }
}
