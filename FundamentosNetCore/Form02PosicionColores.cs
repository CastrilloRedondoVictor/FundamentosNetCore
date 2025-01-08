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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            int positionX = int.Parse(this.txtPositionX.Text);
            int positionY = int.Parse(this.txtPositionY.Text);

            this.btnPosition.Location = new Point(positionX, positionY);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int colorRed = int.Parse(this.txtColorRed.Text);
            int colorGreen = int.Parse(this.txtColorGreen.Text);
            int colorBlue = int.Parse(this.txtColorBlue.Text);

            this.BackColor = Color.FromArgb(colorRed, colorGreen, colorBlue);
        }
    }
}
