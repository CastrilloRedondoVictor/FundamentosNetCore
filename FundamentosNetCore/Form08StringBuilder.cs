using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvert1_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.richTxt.Text;
            krono.Start();
            for (int i = 0; i < cadena.Length; i++)
            {
                char letra = cadena[cadena.Length - 1];

                cadena.Remove(cadena.Length - 1, 1);

                cadena = cadena.Insert(i, letra.ToString());
            }
            krono.Stop();

            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + ", Milisegundos: " + krono.Elapsed.Microseconds;
        }
    }
}
