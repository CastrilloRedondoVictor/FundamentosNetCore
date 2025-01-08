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
    public partial class Form07SumarNumeros : Form
    {
        public Form07SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            bool dato = true;
            string textonumeros = this.txtNumeros.Text;
            int suma = 0;
            for (int i = 0; i < textonumeros.Length; i++) {
                char c = textonumeros[i];

                int numero = int.Parse(c.ToString());
                suma += numero;
            }
            this.lblResultado.Text = "La suma es: " + suma.ToString();
        }
    }
}
