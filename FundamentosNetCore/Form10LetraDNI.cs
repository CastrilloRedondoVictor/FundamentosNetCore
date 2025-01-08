using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FundamentosNetCore
{
    public partial class Form10LetraDNI : Form
    {
        public Form10LetraDNI()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;

            // Extraer el número (los primeros 8 caracteres del DNI)
            int numero = int.Parse(dni.Remove(8));

            // Extraer la letra (el último carácter del DNI)
            string letra = dni.Substring(8, 1);

            // Definir el array de letras
            string[] array = {
                "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B",
                "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E", "T"
            };

            // Calcular el índice usando el módulo
            int calculo = numero - ((numero / 23) * 23);

            // Verificar si la letra calculada coincide con la letra introducida
            if (array[calculo] == letra)
            {
                lblResultado.Text = "El DNI es válido.";
            }
            else
            {
                lblResultado.Text = "El DNI es inválido, su letra es la " + array[calculo];
            }


        }
    }
}
