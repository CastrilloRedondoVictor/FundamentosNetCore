using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {

        public Director():base()
        {
            this.salarioMinimo += 200;
        }

        public int GetVacaciones()
        {
            int vacacionesEmpleado = base.GetVacaciones();
            return vacacionesEmpleado + 8;
        }

        public int GetVacaciones(int extras)
        {
            return this.GetVacaciones() + extras;
        }
    }
}
