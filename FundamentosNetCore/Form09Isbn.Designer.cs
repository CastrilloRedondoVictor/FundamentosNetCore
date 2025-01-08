namespace FundamentosNetCore
{
    partial class Form09Isbn
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
            btnValidar = new Button();
            label1 = new Label();
            lblResultado = new Label();
            txtIsbn = new TextBox();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(201, 121);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 48);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "ISBN";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(238, 169);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 2;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(98, 66);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(178, 23);
            txtIsbn.TabIndex = 3;
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIsbn);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(btnValidar);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private Label label1;
        private Label lblResultado;
        private TextBox txtIsbn;
    }
}