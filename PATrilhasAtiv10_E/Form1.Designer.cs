namespace PATrilhasAtiv10_E
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            lblFonte = new Label();
            btnSair = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(242, 97);
            button1.Name = "button1";
            button1.Size = new Size(107, 23);
            button1.TabIndex = 0;
            button1.Text = "Showcard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(248, 143);
            button2.Name = "button2";
            button2.Size = new Size(94, 23);
            button2.TabIndex = 1;
            button2.Text = "Arial Narrow";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblFonte
            // 
            lblFonte.AutoSize = true;
            lblFonte.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFonte.Location = new Point(211, 27);
            lblFonte.Name = "lblFonte";
            lblFonte.Size = new Size(162, 15);
            lblFonte.TabIndex = 2;
            lblFonte.Text = "Escolha uma Opção de Fonte";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(472, 251);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Ink Free", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(28, 251);
            button4.Name = "button4";
            button4.Size = new Size(81, 23);
            button4.TabIndex = 4;
            button4.Text = "Continuar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 306);
            Controls.Add(button4);
            Controls.Add(btnSair);
            Controls.Add(lblFonte);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblFonte;
        private Button btnSair;
        private Button button4;
    }
}
