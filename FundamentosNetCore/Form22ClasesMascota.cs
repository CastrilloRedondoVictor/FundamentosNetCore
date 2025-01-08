using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Helpers;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form22ClasesMascota : Form
    {

        public HelperMascotas HelperMascotas;
        public Form22ClasesMascota()
        {
            InitializeComponent();
            this.HelperMascotas = new HelperMascotas("Mascotas.txt");
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota(this.txtNombre.Text, this.txtRaza.Text);
            this.HelperMascotas.Mascotas.Add(mascota);
            MessageBox.Show("Mascota añadida. Pulsa GUARDAR para enviar todas al fichero de texto.");
            
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            await this.HelperMascotas.WriteFileAsync();
            MessageBox.Show("Mascotas guardadas. Pulsa LEER para ver todas las mascotas registradas.");
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            this.lstMascotas.Items.Clear();

            await this.HelperMascotas.ReadFileAsync();

            foreach (var masc in HelperMascotas.Mascotas)
            {
                this.lstMascotas.Items.Add(masc.ToString());
            }
        }
    }
}
