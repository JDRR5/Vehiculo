using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public abstract class Vehiculo
    {
        private string matricula;
        private string modelo;
        private double potenciaCV;

        public Vehiculo()
        {
            this.matricula = "Sin matrícula";
            this.modelo = "Modelo genérico";
            this.potenciaCV = 100.0;
        }

        public string GetMatricula() => matricula;
        public string GetModelo() => modelo;
        public double GetPotenciaCV() => potenciaCV;

        public void SetMatricula(string matricula) => this.matricula = matricula;
        public void SetModelo(string modelo) => this.modelo = modelo;
        public void SetPotenciaCV(double potenciaCV) => this.potenciaCV = potenciaCV;

        public virtual string MostrarDatos()
        {
            return $"Vehículo: {modelo}, Matrícula: {matricula}, Potencia: {potenciaCV} CV";
        }
        public abstract string TipoVehiculo();
    }
}
