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
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtNum1.Text);
            int num2 = int.Parse(this.txtNum2.Text);
            int suma = num1 + num2;

            this.lblResultado.Text = "El resultado es: " + suma;
        }
    }
}
