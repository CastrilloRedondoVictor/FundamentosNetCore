namespace FundamentosNetCore
{
    partial class Form06ValidarMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMail = new TextBox();
            bttValidar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 103);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca un mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(328, 121);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(211, 23);
            txtMail.TabIndex = 1;
            // 
            // bttValidar
            // 
            bttValidar.Location = new Point(328, 182);
            bttValidar.Name = "bttValidar";
            bttValidar.Size = new Size(211, 56);
            bttValidar.TabIndex = 2;
            bttValidar.Text = "Validar Email";
            bttValidar.UseVisualStyleBackColor = true;
            bttValidar.Click += bttValidar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(155, 291);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // Form06ValidarMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(bttValidar);
            Controls.Add(txtMail);
            Controls.Add(label1);
            Name = "Form06ValidarMail";
            Text = "Form06ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMail;
        private Button bttValidar;
        private Label lblResultado;
    }
}