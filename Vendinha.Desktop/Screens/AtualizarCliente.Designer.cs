namespace Vendas.Screens
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
            pickerData = new DateTimePicker();
            label5 = new Label();
            Email = new TextBox();
            label4 = new Label();
            CPF = new TextBox();
            label3 = new Label();
            Nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
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
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(342, 411);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(97, 31);
            Confirmar.TabIndex = 21;
            Confirmar.Text = "Atualizar";
            Confirmar.UseVisualStyleBackColor = true;
            // 
            // pickerData
            // 
            pickerData.Format = DateTimePickerFormat.Short;
            pickerData.Location = new Point(12, 335);
            pickerData.Margin = new Padding(2);
            pickerData.Name = "pickerData";
            pickerData.Size = new Size(376, 23);
            pickerData.TabIndex = 20;
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
            // Email
            // 
            Email.Location = new Point(12, 270);
            Email.Name = "Email";
            Email.Size = new Size(376, 23);
            Email.TabIndex = 18;
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
            // CPF
            // 
            CPF.Location = new Point(12, 199);
            CPF.Name = "CPF";
            CPF.Size = new Size(376, 23);
            CPF.TabIndex = 16;
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
            // Nome
            // 
            Nome.Location = new Point(12, 135);
            Nome.Name = "Nome";
            Nome.Size = new Size(376, 23);
            Nome.TabIndex = 14;
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
            label1.Click += label1_Click;
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 23);
            textBox1.TabIndex = 24;
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
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(Voltar);
            Controls.Add(Confirmar);
            Controls.Add(pickerData);
            Controls.Add(label5);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(CPF);
            Controls.Add(label3);
            Controls.Add(Nome);
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
        private DateTimePicker pickerData;
        private Label label5;
        private TextBox Email;
        private Label label4;
        private TextBox CPF;
        private Label label3;
        private TextBox Nome;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label6;
    }
}