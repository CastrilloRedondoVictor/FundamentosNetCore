using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anyo = int.Parse(txtAnyo.Text);

            DateTime fecha = new DateTime(anyo, mes, dia);

            this.lblDiaSemana.Text = fecha.ToString("dddd", new System.Globalization.CultureInfo("es-ES")).ToUpper();
        }
    }
}
