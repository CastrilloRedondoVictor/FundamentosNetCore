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
    public partial class Form11ColeccionGrafica : Form
    {
        public Form11ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtElemento.Text;

            this.lstElementos.Items.Add(elemento);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int elemento = this.lstElementos.SelectedIndex;

            this.lstElementos.Items.RemoveAt(elemento);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblIndexSeleccionado.Text = "Index seleccionado: " + this.lstElementos.SelectedIndex;
                this.lblItemSeleccionado.Text = "Item seleccionado: " + this.lstElementos.SelectedItem;
            }
        }
    }
}
