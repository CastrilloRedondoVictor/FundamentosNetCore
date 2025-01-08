using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public string Path {  get; set; }
        public List<Mascota> Mascotas { get; set; }

        public HelperMascotas(string path)
        {
            this.Path = path;
            this.Mascotas = new List<Mascota>();
        }


        public async Task ReadFileAsync()
        {
            FileInfo file = new FileInfo(this.Path);
            using (TextReader reader = file.OpenText())
            {
                this.Mascotas.Clear();
                string data = await reader.ReadToEndAsync();
                if (data != "") {
                    foreach (var masc in data.Split('/'))
                    {
                        string[] datos = masc.Split(',');
                        Mascota mascota = new Mascota(datos[0], datos[1]);
                        this.Mascotas.Add(mascota);
                    }
                }
                reader.Close();
            }
        }

        public async Task WriteFileAsync()
        {
            FileInfo file = new FileInfo(this.Path);
            using (TextWriter writer = file.CreateText())
            {

                string data = "";
                foreach (var mascota in Mascotas)
                {
                    data += mascota.ToString() + "/";
                }
                data = data.Trim('/');

                await writer.WriteAsync(data);
                await writer.FlushAsync();

                writer.Close();
            }
        }
    }
}
