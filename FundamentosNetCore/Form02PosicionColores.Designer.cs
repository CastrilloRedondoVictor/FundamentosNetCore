namespace FundamentosNetCore
{
    partial class Form02PosicionColores
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
            btnPosition = new Button();
            btnColor = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPositionX = new TextBox();
            txtPositionY = new TextBox();
            txtColorRed = new TextBox();
            txtColorGreen = new TextBox();
            txtColorBlue = new TextBox();
            SuspendLayout();
            // 
            // btnPosition
            // 
            btnPosition.Location = new Point(55, 231);
            btnPosition.Name = "btnPosition";
            btnPosition.Size = new Size(146, 32);
            btnPosition.TabIndex = 0;
            btnPosition.Text = "Cambiar posicion";
            btnPosition.UseVisualStyleBackColor = true;
            btnPosition.Click += btnPosition_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(495, 231);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(138, 32);
            btnColor.TabIndex = 1;
            btnColor.Text = "Cambiar color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Posición X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Posición Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 33);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(477, 101);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(477, 171);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 6;
            label5.Text = "Azul";
            // 
            // txtPositionX
            // 
            txtPositionX.Location = new Point(131, 52);
            txtPositionX.Name = "txtPositionX";
            txtPositionX.Size = new Size(100, 23);
            txtPositionX.TabIndex = 7;
            // 
            // txtPositionY
            // 
            txtPositionY.Location = new Point(131, 137);
            txtPositionY.Name = "txtPositionY";
            txtPositionY.Size = new Size(100, 23);
            txtPositionY.TabIndex = 8;
            // 
            // txtColorRed
            // 
            txtColorRed.Location = new Point(562, 33);
            txtColorRed.Name = "txtColorRed";
            txtColorRed.Size = new Size(100, 23);
            txtColorRed.TabIndex = 9;
            // 
            // txtColorGreen
            // 
            txtColorGreen.Location = new Point(562, 101);
            txtColorGreen.Name = "txtColorGreen";
            txtColorGreen.Size = new Size(100, 23);
            txtColorGreen.TabIndex = 10;
            // 
            // txtColorBlue
            // 
            txtColorBlue.Location = new Point(562, 171);
            txtColorBlue.Name = "txtColorBlue";
            txtColorBlue.Size = new Size(100, 23);
            txtColorBlue.TabIndex = 11;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtColorBlue);
            Controls.Add(txtColorGreen);
            Controls.Add(txtColorRed);
            Controls.Add(txtPositionY);
            Controls.Add(txtPositionX);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnColor);
            Controls.Add(btnPosition);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPosition;
        private Button btnColor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPositionX;
        private TextBox txtPositionY;
        private TextBox txtColorRed;
        private TextBox txtColorGreen;
        private TextBox txtColorBlue;
    }
}