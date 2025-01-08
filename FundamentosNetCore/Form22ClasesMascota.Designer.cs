namespace FundamentosNetCore
{
    partial class Form22ClasesMascota
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
            btnNueva = new Button();
            Nombre = new Label();
            Raza = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            btnLeer = new Button();
            btnGuardar = new Button();
            Mascotas = new Label();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(28, 149);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(75, 23);
            btnNueva.TabIndex = 0;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(28, 21);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Raza
            // 
            Raza.AutoSize = true;
            Raza.Location = new Point(28, 75);
            Raza.Name = "Raza";
            Raza.Size = new Size(31, 15);
            Raza.TabIndex = 2;
            Raza.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(28, 93);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 4;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(28, 193);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 23);
            btnLeer.TabIndex = 5;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(28, 240);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Mascotas
            // 
            Mascotas.AutoSize = true;
            Mascotas.Location = new Point(374, 30);
            Mascotas.Name = "Mascotas";
            Mascotas.Size = new Size(57, 15);
            Mascotas.TabIndex = 7;
            Mascotas.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(374, 48);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(414, 379);
            lstMascotas.TabIndex = 8;
            // 
            // Form22ClasesMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstMascotas);
            Controls.Add(Mascotas);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(Raza);
            Controls.Add(Nombre);
            Controls.Add(btnNueva);
            Name = "Form22ClasesMascota";
            Text = "Form22ClasesMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNueva;
        private Label Nombre;
        private Label Raza;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Button btnLeer;
        private Button btnGuardar;
        private Label Mascotas;
        private ListBox lstMascotas;
    }
}