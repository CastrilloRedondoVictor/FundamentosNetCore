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
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = txtIsbn.Text;

            if (isbn.Length != 10)
            {
                lblResultado.Text = "ISBN incorrecto";
            } else
            {
                int result = 0;
                for (int i = 1; i <= isbn.Length; i++) {
                    int num = int.Parse(isbn.Substring(i - 1, 1).ToString());
                    result += num * i;
                }
                if (result % 11 == 0) {

                    lblResultado.Text = "ISBN correcto";
                } else
                {
                    lblResultado.Text = "ISBN incorrecto";
                }
            }
        }
    }
}
