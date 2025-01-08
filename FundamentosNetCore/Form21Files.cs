using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Helpers;

namespace FundamentosNetCore
{
    public partial class Form21Files : Form
    {

        private string Path { get; set; }

        public Form21Files()
        {
            InitializeComponent();
            this.Path = "file1.txt";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
        }

        public string getNombresListBox()
        {
            string data = "";
            foreach (var name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {

            string data = this.getNombresListBox();

            await HelperFiles.WriteFileAsync(this.Path, data);
            MessageBox.Show("Datos guardados");
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {

            string data = await HelperFiles.ReadFileAsync(this.Path);
            this.RellenarListBox(data);
            this.txtContenido.Text = data;
        }

        public void RellenarListBox(string nombres)
        {
            string[] data = nombres.Split(',');

            this.lstNombres.Items.Clear();

            foreach (string name in data)
            {
                this.lstNombres.Items.Add(name);
            }
        }
    }
}
