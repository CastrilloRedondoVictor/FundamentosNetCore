using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Models
{    
    public class Mascota
    {
        public string nombre { get; set; }
        public string raza { get; set; }
        public int Years {  get; set; }

        public Mascota(string nombre, string raza) {
            this.nombre = nombre;
            this.raza = raza;
        }

        public Mascota() { }


        public override string ToString()
        {
            return $"{this.nombre},{this.raza}";
        }

    }
}
