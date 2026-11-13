namespace Vendinha.Desktop
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
            Atualizar = new Button();
            CadastrarCliente = new Button();
            Consultar = new Button();
            label1 = new Label();
            CadastrarDividas = new Button();
            SuspendLayout();
            // 
            // Atualizar
            // 
            Atualizar.Location = new Point(727, 233);
            Atualizar.Name = "Atualizar";
            Atualizar.Size = new Size(121, 45);
            Atualizar.TabIndex = 0;
            Atualizar.Text = "Atualizar";
            Atualizar.UseVisualStyleBackColor = true;
            Atualizar.Click += button3_Click;
            // 
            // CadastrarCliente
            // 
            CadastrarCliente.Location = new Point(114, 233);
            CadastrarCliente.Name = "CadastrarCliente";
            CadastrarCliente.Size = new Size(121, 45);
            CadastrarCliente.TabIndex = 1;
            CadastrarCliente.Text = "Cadastrar Cliente";
            CadastrarCliente.UseVisualStyleBackColor = true;
            CadastrarCliente.Click += button2_Click;
            // 
            // Consultar
            // 
            Consultar.Location = new Point(533, 233);
            Consultar.Name = "Consultar";
            Consultar.Size = new Size(121, 45);
            Consultar.TabIndex = 3;
            Consultar.Text = "Consultar e Excluir";
            Consultar.UseVisualStyleBackColor = true;
            Consultar.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(346, 98);
            label1.Name = "label1";
            label1.Size = new Size(238, 59);
            label1.TabIndex = 4;
            label1.Text = "VENDINHA";
            // 
            // CadastrarDividas
            // 
            CadastrarDividas.Location = new Point(324, 233);
            CadastrarDividas.Name = "CadastrarDividas";
            CadastrarDividas.Size = new Size(121, 45);
            CadastrarDividas.TabIndex = 5;
            CadastrarDividas.Text = "Cadastrar Dívida";
            CadastrarDividas.UseVisualStyleBackColor = true;
            CadastrarDividas.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 505);
            Controls.Add(CadastrarDividas);
            Controls.Add(label1);
            Controls.Add(Consultar);
            Controls.Add(CadastrarCliente);
            Controls.Add(Atualizar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Atualizar;
        private Button CadastrarCliente;
        private Button Consultar;
        private Label label1;
        private Button CadastrarDividas;
    }
}
