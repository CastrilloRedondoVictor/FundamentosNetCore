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
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();

            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }


        private void eliminarSeleccionados()
        {
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string nuevo = this.txtProducto.Text;

            if (this.lstTienda.Items.Contains(nuevo))
            {
                this.lstTienda.SelectedItem = nuevo;
            }
            else
            {
                this.lstTienda.Items.Add(nuevo);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarSeleccionados();
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            foreach (var item in this.lstTienda.SelectedItems)
            {
                this.lstAlmacen.Items.Add(item);
            }

            eliminarSeleccionados();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (var item in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(item);
            }

            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.lstAlmacen.SelectedIndex;
            var selectedItem = this.lstAlmacen.SelectedItem;
            if (selectedIndex > 0)
            {
                var previousItem = this.lstAlmacen.Items[selectedIndex - 1];
                this.lstAlmacen.Items[selectedIndex - 1] = selectedItem;
                this.lstAlmacen.Items[selectedIndex] = previousItem;
                this.lstAlmacen.SelectedIndex = selectedIndex - 1;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.lstAlmacen.SelectedIndex;
            var selectedItem = this.lstAlmacen.SelectedItem;
            if (selectedIndex < lstAlmacen.Items.Count - 1)
            {
                var nextItem = this.lstAlmacen.Items[selectedIndex + 1];
                this.lstAlmacen.Items[selectedIndex + 1] = selectedItem;
                this.lstAlmacen.Items[selectedIndex] = nextItem;
                this.lstAlmacen.SelectedIndex = selectedIndex + 1;
            }
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAlmacen.SelectedIndex == 0) { 
                btnSubir.Enabled = false;
            } else
            {
                btnSubir.Enabled = true;
            }
            if (lstAlmacen.SelectedIndex == lstAlmacen.Items.Count - 1)
            {
                btnBajar.Enabled = false;
            } else
            {
                btnBajar.Enabled = true;
            }
        }
    }
}
