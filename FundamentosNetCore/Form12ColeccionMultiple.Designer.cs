namespace FundamentosNetCore
{
    partial class Form12ColeccionMultiple
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
            lblIndexSeleccionado = new Label();
            lblItemSeleccionado = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            txtElemento = new TextBox();
            btnInsertar = new Button();
            label1 = new Label();
            lstElementos = new ListBox();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(82, 368);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(114, 15);
            lblIndexSeleccionado.TabIndex = 17;
            lblIndexSeleccionado.Text = "Index seleccionado: ";
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(82, 322);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(109, 15);
            lblItemSeleccionado.TabIndex = 16;
            lblItemSeleccionado.Text = "Item seleccionado: ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(579, 210);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(579, 160);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 84);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 13;
            label2.Text = "Nuevo elemento";
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(579, 102);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(100, 23);
            txtElemento.TabIndex = 12;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(579, 131);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 11;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 39);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 10;
            label1.Text = "Elementos Multiple";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(82, 57);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(334, 229);
            lstElementos.TabIndex = 9;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(579, 288);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(95, 27);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form12ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(txtElemento);
            Controls.Add(btnInsertar);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form12ColeccionMultiple";
            Text = "Form12ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndexSeleccionado;
        private Label lblItemSeleccionado;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtElemento;
        private Button btnInsertar;
        private Label label1;
        private ListBox lstElementos;
        private Button btnSeleccionados;
    }
}