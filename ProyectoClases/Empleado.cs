using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {

        public int salarioMinimo { get; protected set; }

        public Empleado():base("Nombre", "Apellidos") {
            this.salarioMinimo = 1400;
            Debug.WriteLine("Constructor vacío empleado");
        }

        public Empleado(string nombre, string apellidos):base(nombre, apellidos)
        {

            Debug.WriteLine("Constructor con parámetros EMPLEADO");

            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.salarioMinimo = 1400;
        }

        public int GetVacaciones()
        {
            return 22;
        }
    }
}
