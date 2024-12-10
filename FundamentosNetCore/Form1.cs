namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Algo aqui...";
            this.SuspendLayout();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            this.lblTexto.Text = "Su nombre es: " + nombre;
            this.lblTexto.Location = new Point(20, 10);
            this.lblTexto.Width = 130;
        }
    }
}
