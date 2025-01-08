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
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void bttValidar_Click(object sender, EventArgs e)
        {
            string resultado = "";
            string email = this.txtMail.Text;
            int length = email.Length - 1;

            if(email.Contains("@") && email.Contains(".")) {
                if (!email.StartsWith("@") && !email.EndsWith("@"))
                {
                    if (email.IndexOf("@", 0) == email.LastIndexOf("@")) {
                        int indexArroba = email.LastIndexOf("@");
                        if (email.Substring(indexArroba).Contains("."))
                        {
                            int indexLastDot = email.LastIndexOf('.');
                            if (email.Substring(indexLastDot).Length - 1 >= 2 && email.Substring(indexLastDot).Length - 1 <= 4)
                            {
                                resultado = "VÁLIDO";
                            }
                            else
                            {
                                resultado = "NO";
                            }
                        }
                        else
                        {
                            resultado = "NO";
                        }
                    }
                    else
                    {
                        resultado = "NO";
                    }
                }
                else
                {
                    resultado = "NO";
                }
            }
            else
            {
                resultado = "NO";
            }

            this.lblResultado.Text = resultado;
            
        }
    }
}
