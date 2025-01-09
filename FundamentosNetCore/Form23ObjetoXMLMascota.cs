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
    public partial class Form23ObjetoXMLMascota : Form
    {

        XmlSerializer serializer;
        public Form23ObjetoXMLMascota()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota(this.txtNombre.Text, this.txtRaza.Text);
            mascota.Years = int.Parse(this.txtAnios.Text);

            using (StreamWriter sw = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(sw, mascota);
                await sw.FlushAsync();
                sw.Close();
            }

            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtAnios.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using(StreamReader sr = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota) this.serializer.Deserialize(sr);
                sr.Close();
                this.txtNombre.Text = mascota.nombre;
                this.txtRaza.Text = mascota.raza;
                this.txtAnios.Text = mascota.Years.ToString();
            }

        }
    }
}
