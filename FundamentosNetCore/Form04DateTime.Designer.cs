namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            txtFecha = new TextBox();
            chkFormato = new CheckBox();
            grpIncremento = new GroupBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            btnIncremento = new Button();
            txtIncremento = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            grpIncremento.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 30);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(55, 48);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(55, 99);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(149, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar formato fecha";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // grpIncremento
            // 
            grpIncremento.Controls.Add(label2);
            grpIncremento.Controls.Add(txtIncremento);
            grpIncremento.Controls.Add(btnIncremento);
            grpIncremento.Controls.Add(rdbAnyos);
            grpIncremento.Controls.Add(rdbMeses);
            grpIncremento.Controls.Add(rdbDias);
            grpIncremento.Location = new Point(55, 146);
            grpIncremento.Name = "grpIncremento";
            grpIncremento.Size = new Size(246, 148);
            grpIncremento.TabIndex = 3;
            grpIncremento.TabStop = false;
            grpIncremento.Text = "groupBox1";
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(0, 37);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 0;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(0, 78);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 1;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(0, 114);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(52, 19);
            rdbAnyos.TabIndex = 2;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(140, 88);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(100, 36);
            btnIncremento.TabIndex = 3;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(140, 59);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 41);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "Incremento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 333);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 4;
            label3.Text = "Nueva Fecha:";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(55, 362);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(246, 23);
            txtNuevaFecha.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(grpIncremento);
            Controls.Add(chkFormato);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            grpIncremento.ResumeLayout(false);
            grpIncremento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFecha;
        private CheckBox chkFormato;
        private GroupBox grpIncremento;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnIncremento;
        private RadioButton rdbAnyos;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}