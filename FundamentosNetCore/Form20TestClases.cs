using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona("Víctor", "Castrillo Redondo");
            persona.Edad = 22;
            persona.Genero = TipoGenero.Masculino;
            persona.Pais = Paises.España;
            persona.Domicilio = new Direccion("Francos Rodriguez", "Madrid", "28039");
            persona.Pais = Paises.España;
            this.lstClases.Items.Add(persona.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            this.lstClases.Items.Add(empleado.GetNombreCompleto() + " SalarioMin: " + empleado.salarioMinimo + " Vacaciones: " + empleado.GetVacaciones());

            Director director = new Director();
            this.lstClases.Items.Add(director.GetNombreCompleto() + " SalarioMin: " + director.salarioMinimo + " Vacaciones: " + director.GetVacaciones());
        }
    }
}
