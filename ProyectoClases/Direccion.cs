using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }

        public Direccion() { }

        public Direccion(string calle, string ciudad) { 
            this.Calle = calle;
            this.Ciudad = ciudad;
        }

        public Direccion(string calle, string ciudad, string codigoPostal)
        {
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = codigoPostal;
        }


        public override string ToString()
        {
            return $"{this.Calle}, {this.Ciudad}, {this.CodigoPostal}";
        }
    }
}
