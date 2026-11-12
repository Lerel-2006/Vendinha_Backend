namespace Forms1
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
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(308, 245);
            button1.Name = "button1";
            button1.Size = new Size(121, 45);
            button1.TabIndex = 0;
            button1.Text = "Atualizar Dívida";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(189, 171);
            button2.Name = "button2";
            button2.Size = new Size(121, 45);
            button2.TabIndex = 1;
            button2.Text = "Cadastrar Cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(611, 171);
            button3.Name = "button3";
            button3.Size = new Size(121, 45);
            button3.TabIndex = 2;
            button3.Text = "Excluir Cliente ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(523, 245);
            button4.Name = "button4";
            button4.Size = new Size(121, 45);
            button4.TabIndex = 3;
            button4.Text = "Consultar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(345, 31);
            label1.Name = "label1";
            label1.Size = new Size(238, 59);
            label1.TabIndex = 4;
            label1.Text = "VENDINHA";
            // 
            // button5
            // 
            button5.Location = new Point(409, 171);
            button5.Name = "button5";
            button5.Size = new Size(121, 45);
            button5.TabIndex = 5;
            button5.Text = "Cadastrar Dívida";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 505);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
    }
}
