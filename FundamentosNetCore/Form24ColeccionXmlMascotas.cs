using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form24ColeccionXmlMascotas : Form
    {
        XmlSerializer serializer;
        MascotasList mascotas;
        public Form24ColeccionXmlMascotas()
        {
            InitializeComponent();
            mascotas = new MascotasList();
            this.serializer = new XmlSerializer(mascotas.GetType());
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota(this.txtNombre.Text, this.txtRaza.Text);
            mascota.Years = int.Parse(this.txtAnios.Text);

            this.mascotas.Add(mascota);
            this.FillMascotas();
            this.ClearBoxes();
        }

        public void FillMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotas)
            {
                this.lstMascotas.Items.Add(mascota.nombre.ToUpper());
            }
        }

        public void ClearBoxes()
        {
            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtAnios.Clear();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("mascotas.xml"))
            {
                this.mascotas = (MascotasList) this.serializer.Deserialize(sr);
                sr.Close();
                this.FillMascotas();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("mascotas.xml"))
            {
                this.serializer.Serialize(sw, this.mascotas);
                await sw.FlushAsync();
                sw.Close();
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstMascotas.SelectedIndex != -1)
            {
                Mascota mascota = this.mascotas[this.lstMascotas.SelectedIndex];
                this.txtNombre.Text = mascota.nombre;
                this.txtRaza.Text = mascota.raza;
                this.txtAnios.Text = mascota.Years.ToString();
            }
        }
    }
}
