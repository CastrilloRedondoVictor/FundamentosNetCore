namespace FundamentosNetCore
{
    partial class Form21Files
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
            txtContenido = new TextBox();
            label1 = new Label();
            btnNuevo = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(65, 72);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(252, 335);
            txtContenido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 54);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Contenido File";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(346, 154);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(141, 41);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo nombre";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(346, 201);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(141, 42);
            btnRead.TabIndex = 3;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(346, 249);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(141, 39);
            btnWrite.TabIndex = 4;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 54);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(369, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(534, 54);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 7;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(534, 72);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(219, 334);
            lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Controls.Add(txtContenido);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContenido;
        private Label label1;
        private Button btnNuevo;
        private Button btnRead;
        private Button btnWrite;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private ListBox lstNombres;
    }
}