namespace FundamentosNetCore
{
    partial class Form11ColeccionGrafica
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
            lstElementos = new ListBox();
            label1 = new Label();
            btnInsertar = new Button();
            txtElemento = new TextBox();
            label2 = new Label();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            lblItemSeleccionado = new Label();
            lblIndexSeleccionado = new Label();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(49, 47);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(334, 229);
            lstElementos.TabIndex = 0;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Elementos";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(546, 121);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(546, 92);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(100, 23);
            txtElemento.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 74);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Nuevo elemento";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(546, 150);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(546, 200);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(49, 312);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(109, 15);
            lblItemSeleccionado.TabIndex = 7;
            lblItemSeleccionado.Text = "Item seleccionado: ";
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(49, 358);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(114, 15);
            lblIndexSeleccionado.TabIndex = 8;
            lblIndexSeleccionado.Text = "Index seleccionado: ";
            // 
            // Form11ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(txtElemento);
            Controls.Add(btnInsertar);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form11ColeccionGrafica";
            Text = "Form11ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstElementos;
        private Label label1;
        private Button btnInsertar;
        private TextBox txtElemento;
        private Label label2;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label lblItemSeleccionado;
        private Label lblIndexSeleccionado;
    }
}