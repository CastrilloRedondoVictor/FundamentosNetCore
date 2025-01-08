namespace FundamentosNetCore
{
    partial class Form08StringBuilder
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
            richTxt = new RichTextBox();
            label1 = new Label();
            btnInvert1 = new Button();
            btnInvert2 = new Button();
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // richTxt
            // 
            richTxt.Location = new Point(41, 59);
            richTxt.Name = "richTxt";
            richTxt.Size = new Size(629, 252);
            richTxt.TabIndex = 0;
            richTxt.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 41);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 1;
            label1.Text = "Copie el texto para trabajar";
            // 
            // btnInvert1
            // 
            btnInvert1.Location = new Point(41, 365);
            btnInvert1.Name = "btnInvert1";
            btnInvert1.Size = new Size(137, 56);
            btnInvert1.TabIndex = 2;
            btnInvert1.Text = "Invertir String";
            btnInvert1.UseVisualStyleBackColor = true;
            btnInvert1.Click += btnInvert1_Click;
            // 
            // btnInvert2
            // 
            btnInvert2.Location = new Point(515, 365);
            btnInvert2.Name = "btnInvert2";
            btnInvert2.Size = new Size(155, 56);
            btnInvert2.TabIndex = 3;
            btnInvert2.Text = "Invertir con Builder";
            btnInvert2.UseVisualStyleBackColor = true;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(354, 365);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(0, 15);
            lblTiempo.TabIndex = 4;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTiempo);
            Controls.Add(btnInvert2);
            Controls.Add(btnInvert1);
            Controls.Add(label1);
            Controls.Add(richTxt);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTxt;
        private Label label1;
        private Button btnInvert1;
        private Button btnInvert2;
        private Label lblTiempo;
    }
}