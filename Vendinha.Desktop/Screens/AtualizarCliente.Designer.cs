namespace Vendinha.Desktop.Screens
{
    partial class AtualizarCliente
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
            Voltar = new Button();
            Confirmar = new Button();
            DataBox = new DateTimePicker();
            label5 = new Label();
            EmailBox = new TextBox();
            label4 = new Label();
            CPFBox = new TextBox();
            label3 = new Label();
            NomeBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            IdBox = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // Voltar
            // 
            Voltar.Location = new Point(515, 411);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(99, 31);
            Voltar.TabIndex = 22;
            Voltar.Text = "Voltar";
            Voltar.UseVisualStyleBackColor = true;
            Voltar.Click += Voltar_Click;

            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(342, 411);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(97, 31);
            Confirmar.TabIndex = 21;
            Confirmar.Text = "Atualizar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += Confirmar_Click;
            
            // 
            // DataBox
            // 
            DataBox.Format = DateTimePickerFormat.Short;
            DataBox.Location = new Point(12, 335);
            DataBox.Margin = new Padding(2);
            DataBox.Name = "DataBox";
            DataBox.Size = new Size(376, 23);
            DataBox.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 312);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 19;
            label5.Text = "Data de Nascimento";
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(12, 270);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(376, 23);
            EmailBox.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 246);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 17;
            label4.Text = "E-MAIL";
            // 
            // CPFBox
            // 
            CPFBox.Location = new Point(12, 199);
            CPFBox.Name = "CPFBox";
            CPFBox.Size = new Size(376, 23);
            CPFBox.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 175);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 15;
            label3.Text = "CPF";
            // 
            // NomeBox
            // 
            NomeBox.Location = new Point(12, 135);
            NomeBox.Name = "NomeBox";
            NomeBox.Size = new Size(376, 23);
            NomeBox.TabIndex = 14;
            NomeBox.TextChanged += NomeBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 13;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28F);
            label2.Location = new Point(4, 15);
            label2.Name = "label2";
            label2.Size = new Size(295, 51);
            label2.TabIndex = 12;
            label2.Text = "Atualizar Cliente";
            // 
            // IdBox
            // 
            IdBox.Location = new Point(12, 90);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(376, 23);
            IdBox.TabIndex = 24;
            IdBox.TextChanged += IdBox_TextChanged;

            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 66);
            label6.Name = "label6";
            label6.Size = new Size(27, 21);
            label6.TabIndex = 23;
            label6.Text = "Id ";
            // 
            // AtualizarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 527);
            Controls.Add(IdBox);
            Controls.Add(label6);
            Controls.Add(Voltar);
            Controls.Add(Confirmar);
            Controls.Add(DataBox);
            Controls.Add(label5);
            Controls.Add(EmailBox);
            Controls.Add(label4);
            Controls.Add(CPFBox);
            Controls.Add(label3);
            Controls.Add(NomeBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "AtualizarCliente";
            Text = "AtualizarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Voltar;
        private Button Confirmar;
        private DateTimePicker DataBox;
        private Label label5;
        private TextBox EmailBox;
        private Label label4;
        private TextBox CPFBox;
        private Label label3;
        private TextBox NomeBox;
        private Label label1;
        private Label label2;
        private TextBox IdBox;
        private Label label6;
    }
}