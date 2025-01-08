namespace FundamentosNetCore
{
    partial class Form07SumarNumeros
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
            btnSumar = new Button();
            txtNumeros = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(152, 160);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "SUMAR";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(141, 108);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(100, 23);
            txtNumeros.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(171, 224);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 2;
            // 
            // Form07SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtNumeros);
            Controls.Add(btnSumar);
            Name = "Form07SumarNumeros";
            Text = "Form07SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private TextBox txtNumeros;
        private Label lblResultado;
    }
}