namespace Vendinha.Desktop.Screens

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
            nomeBox = new TextBox();
            label3 = new Label();
            CpfBox = new TextBox();
            EmailBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            DataBox = new DateTimePicker();
            Confirmar = new Button();
            Limpar = new Button();
            sair = new Button();
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
            label1.Size = new Size(53, 21);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // nomeBox
            // 
            nomeBox.Location = new Point(12, 104);
            nomeBox.Name = "nomeBox1";
            nomeBox.Size = new Size(376, 23);
            nomeBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // CpfBox
            // 
            CpfBox.Location = new Point(12, 168);
            CpfBox.Name = "CpfBox";
            CpfBox.Size = new Size(376, 23);
            CpfBox.TabIndex = 5;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(12, 239);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(376, 23);
            EmailBox.TabIndex = 7;
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
            // 
            // DataBox
            // 
            DataBox.Format = DateTimePickerFormat.Short;
            DataBox.Location = new Point(12, 304);
            DataBox.Margin = new Padding(2);
            DataBox.Name = "DataBox";
            DataBox.Size = new Size(376, 23);
            DataBox.TabIndex = 9;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(337, 395);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(97, 31);
            Confirmar.TabIndex = 10;
            Confirmar.Text = "Cadastrar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += btnCadastrar_Click;
            
            // 
            // Limpar
            // 
            Limpar.Location = new Point(510, 395);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(99, 31);
            Limpar.TabIndex = 11;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            Limpar.Click += btnLimpar_Click;
            
            // 
            // sair
            // 
            sair.Location = new Point(689, 395);
            sair.Name = "sair";
            sair.Size = new Size(99, 31);
            sair.TabIndex = 12;
            sair.Text = "Sair";
            sair.UseVisualStyleBackColor = true;
            sair.Click += btnSair_Click;
            // 
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 517);
            Controls.Add(sair);
            Controls.Add(Limpar);
            Controls.Add(Confirmar);
            Controls.Add(DataBox);
            Controls.Add(label5);
            Controls.Add(EmailBox);
            Controls.Add(label4);
            Controls.Add(CpfBox);
            Controls.Add(label3);
            Controls.Add(nomeBox);
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
        private TextBox nomeBox;
        private Label label3;
        private TextBox CpfBox;
        private TextBox EmailBox;
        private Label label4;
        private Label label5;
        private DateTimePicker DataBox;
        private Button Confirmar;
        private Button Limpar;
        private Button sair;
    }
}