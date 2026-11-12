namespace Vendas.Screens
{
    partial class ConsultarExcluir
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Idade = new DataGridViewTextBoxColumn();
            Dividas = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            DataCriacao = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            Excluir = new Button();
            Sair = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, CPF, Idade, Dividas, Valor, DataCriacao, Situacao });
            dataGridView1.Location = new Point(25, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(834, 281);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            // 
            // Idade
            // 
            Idade.HeaderText = "Idade";
            Idade.Name = "Idade";
            Idade.ReadOnly = true;
            // 
            // Dividas
            // 
            Dividas.HeaderText = "Dividas";
            Dividas.Name = "Dividas";
            Dividas.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // DataCriacao
            // 
            DataCriacao.HeaderText = "Data de Criação";
            DataCriacao.Name = "DataCriacao";
            DataCriacao.ReadOnly = true;
            // 
            // Situacao
            // 
            Situacao.HeaderText = "Situação";
            Situacao.Name = "Situacao";
            Situacao.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(207, 9);
            label1.Name = "label1";
            label1.Size = new Size(429, 51);
            label1.TabIndex = 1;
            label1.Text = "CONSULTA DE CLIENTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28F);
            label2.Location = new Point(115, 373);
            label2.Name = "label2";
            label2.Size = new Size(163, 51);
            label2.TabIndex = 2;
            label2.Text = "EXCLUIR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 440);
            label3.Name = "label3";
            label3.Size = new Size(241, 15);
            label3.TabIndex = 3;
            label3.Text = "Digite o ID do cliente que você deseja Excluir";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 458);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 23);
            textBox1.TabIndex = 4;
            // 
            // Excluir
            // 
            Excluir.Location = new Point(147, 496);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(85, 32);
            Excluir.TabIndex = 5;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            // 
            // Sair
            // 
            Sair.Location = new Point(686, 444);
            Sair.Name = "Sair";
            Sair.Size = new Size(92, 49);
            Sair.TabIndex = 6;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            // 
            // ConsultarExcluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 540);
            Controls.Add(Sair);
            Controls.Add(Excluir);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ConsultarExcluir";
            Text = "ConsultarExcluir";
            Load += ConsultarExcluir_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn DataNascimento;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn Dividas;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn DataCriacao;
        private DataGridViewTextBoxColumn Situacao;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button Excluir;
        private Button Sair;
    }
}