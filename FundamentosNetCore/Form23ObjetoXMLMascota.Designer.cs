namespace FundamentosNetCore
{
    partial class Form23ObjetoXMLMascota
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
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            txtAnios = new TextBox();
            btnLeer = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 118);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Raza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 206);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Años";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(70, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(70, 136);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 4;
            // 
            // txtAnios
            // 
            txtAnios.Location = new Point(70, 224);
            txtAnios.Name = "txtAnios";
            txtAnios.Size = new Size(100, 23);
            txtAnios.TabIndex = 5;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(364, 78);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(96, 55);
            btnLeer.TabIndex = 6;
            btnLeer.Text = "Leer dato";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(364, 169);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 52);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar dato";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form23ObjetoXMLMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 330);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(txtAnios);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form23ObjetoXMLMascota";
            Text = "Form23ObjetoXMLMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private TextBox txtAnios;
        private Button btnLeer;
        private Button btnGuardar;
    }
}