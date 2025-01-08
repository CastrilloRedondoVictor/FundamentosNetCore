namespace FundamentosNetCore
{
    partial class Form05Char
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
            txtNum = new TextBox();
            txtLetras = new TextBox();
            label2 = new Label();
            txtSimbolos = new TextBox();
            label3 = new Label();
            txtPuntuacion = new TextBox();
            label4 = new Label();
            btnRun = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(35, 36);
            txtNum.Multiline = true;
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(191, 144);
            txtNum.TabIndex = 1;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(474, 51);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(191, 144);
            txtLetras.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(474, 33);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Letras";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(35, 251);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(191, 144);
            txtSimbolos.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 233);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Símbolos";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(474, 251);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(191, 144);
            txtPuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(474, 233);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Puntuación";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(344, 392);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(75, 23);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(344, 230);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(10, 8);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnRun);
            Controls.Add(txtPuntuacion);
            Controls.Add(label4);
            Controls.Add(txtSimbolos);
            Controls.Add(label3);
            Controls.Add(txtLetras);
            Controls.Add(label2);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private TextBox txtLetras;
        private Label label2;
        private TextBox txtSimbolos;
        private Label label3;
        private TextBox txtPuntuacion;
        private Label label4;
        private Button btnRun;
        private RichTextBox richTextBox1;
    }
}