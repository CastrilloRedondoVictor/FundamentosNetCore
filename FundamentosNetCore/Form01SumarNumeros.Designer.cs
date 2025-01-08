namespace FundamentosNetCore
{
    partial class Form01SumarNumeros
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnSumar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(221, 87);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(461, 87);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 1;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(355, 144);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 69);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Num 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 69);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Num 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 90);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 5;
            label3.Text = "+";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(373, 200);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 6;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSumar);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnSumar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResultado;
    }
}