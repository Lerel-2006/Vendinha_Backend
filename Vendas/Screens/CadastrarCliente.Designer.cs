namespace Forms1
{
    partial class CadastrarCliente
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
            label2 = new Label();
            label1 = new Label();
            Nome = new TextBox();
            label3 = new Label();
            CPF = new TextBox();
            Email = new TextBox();
            label4 = new Label();
            label5 = new Label();
            pickerData = new DateTimePicker();
            Confirmar = new Button();
            Limpar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28F);
            label2.Location = new Point(-1, -1);
            label2.Name = "label2";
            label2.Size = new Size(307, 51);
            label2.TabIndex = 1;
            label2.Text = "Cadastrar Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // Nome
            // 
            Nome.Location = new Point(12, 104);
            Nome.Name = "Nome";
            Nome.Size = new Size(376, 23);
            Nome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 4;
            label3.Text = "CPF:";
            // 
            // CPF
            // 
            CPF.Location = new Point(12, 168);
            CPF.Name = "CPF";
            CPF.Size = new Size(376, 23);
            CPF.TabIndex = 5;
            // 
            // Email
            // 
            Email.Location = new Point(12, 239);
            Email.Name = "Email";
            Email.Size = new Size(376, 23);
            Email.TabIndex = 7;
            Email.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 215);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 6;
            label4.Text = "E-MAIL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 281);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 8;
            label5.Text = "Data de Nascimento";
            label5.Click += label5_Click;
            // 
            // pickerData
            // 
            pickerData.Format = DateTimePickerFormat.Short;
            pickerData.Location = new Point(12, 304);
            pickerData.Margin = new Padding(2);
            pickerData.Name = "pickerData";
            pickerData.Size = new Size(376, 23);
            pickerData.TabIndex = 9;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(337, 395);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(97, 31);
            Confirmar.TabIndex = 10;
            Confirmar.Text = "Cadastrar";
            Confirmar.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(510, 395);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(99, 31);
            Limpar.TabIndex = 11;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            // 
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 517);
            Controls.Add(Limpar);
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
            Name = "CadastrarCliente";
            Text = "CadastrarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox Nome;
        private Label label3;
        private TextBox CPF;
        private TextBox Email;
        private Label label4;
        private Label label5;
        private DateTimePicker pickerData;
        private Button Confirmar;
        private Button Limpar;
    }
}