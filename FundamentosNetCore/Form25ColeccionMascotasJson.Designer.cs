﻿namespace FundamentosNetCore
{
    partial class Form25ColeccionMascotasJson
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
            txtAnios = new TextBox();
            label1 = new Label();
            lstMascotas = new ListBox();
            Mascotas = new Label();
            btnGuardar = new Button();
            btnLeer = new Button();
            txtRaza = new TextBox();
            txtNombre = new TextBox();
            Raza = new Label();
            Nombre = new Label();
            btnNueva = new Button();
            SuspendLayout();
            // 
            // txtAnios
            // 
            txtAnios.Location = new Point(20, 154);
            txtAnios.Name = "txtAnios";
            txtAnios.Size = new Size(100, 23);
            txtAnios.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 136);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 29;
            label1.Text = "Años";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(366, 49);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(414, 379);
            lstMascotas.TabIndex = 28;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Mascotas
            // 
            Mascotas.AutoSize = true;
            Mascotas.Location = new Point(366, 31);
            Mascotas.Name = "Mascotas";
            Mascotas.Size = new Size(57, 15);
            Mascotas.TabIndex = 27;
            Mascotas.Text = "Mascotas";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(20, 324);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(20, 277);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 23);
            btnLeer.TabIndex = 25;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(20, 94);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 24;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(20, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 23;
            // 
            // Raza
            // 
            Raza.AutoSize = true;
            Raza.Location = new Point(20, 76);
            Raza.Name = "Raza";
            Raza.Size = new Size(31, 15);
            Raza.TabIndex = 22;
            Raza.Text = "Raza";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(20, 22);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 21;
            Nombre.Text = "Nombre";
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(20, 233);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(75, 23);
            btnNueva.TabIndex = 20;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // Form25ColeccionMascotasJson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAnios);
            Controls.Add(label1);
            Controls.Add(lstMascotas);
            Controls.Add(Mascotas);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(Raza);
            Controls.Add(Nombre);
            Controls.Add(btnNueva);
            Name = "Form25ColeccionMascotasJson";
            Text = "Form25ColeccionMascotasJson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnios;
        private Label label1;
        private ListBox lstMascotas;
        private Label Mascotas;
        private Button btnGuardar;
        private Button btnLeer;
        private TextBox txtRaza;
        private TextBox txtNombre;
        private Label Raza;
        private Label Nombre;
        private Button btnNueva;
    }
}