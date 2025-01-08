namespace FundamentosNetCore
{
    partial class Form13ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrarDatos = new Button();
            Suma = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            labParesel3 = new Label();
            txtImpares = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 33);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(54, 51);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(131, 319);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(332, 51);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(116, 66);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(332, 143);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(116, 73);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // Suma
            // 
            Suma.AutoSize = true;
            Suma.Location = new Point(332, 254);
            Suma.Name = "Suma";
            Suma.Size = new Size(37, 15);
            Suma.TabIndex = 4;
            Suma.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(390, 254);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 5;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(390, 298);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 7;
            // 
            // labParesel3
            // 
            labParesel3.AutoSize = true;
            labParesel3.Location = new Point(332, 298);
            labParesel3.Name = "labParesel3";
            labParesel3.Size = new Size(35, 15);
            labParesel3.TabIndex = 6;
            labParesel3.Text = "Pares";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(390, 347);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 347);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Impares";
            // 
            // Form13ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 419);
            Controls.Add(txtImpares);
            Controls.Add(label4);
            Controls.Add(txtPares);
            Controls.Add(labParesel3);
            Controls.Add(txtSuma);
            Controls.Add(Suma);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Name = "Form13ColeccionNumeros";
            Text = "Form13ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label Suma;
        private TextBox txtSuma;
        private TextBox txtPares;
        private Label labParesel3;
        private TextBox txtImpares;
        private Label label4;
    }
}