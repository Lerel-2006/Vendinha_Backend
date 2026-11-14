
namespace Vendinha.Desktop.Screens
{
    partial class ConsultarExcluir
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            IdCliente = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Idade = new DataGridViewTextBoxColumn();
            Dividas = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            DataCriacao = new DataGridViewTextBoxColumn();
            DataPagamento = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            label1 = new Label();
            Excluir = new Button();
            Sair = new Button();
            txtPesquisa = new TextBox();
            button1 = new Button();
            Anterior = new Button();
            Proximo = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // dataGridView1
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                ID, IdCliente, Nome, CPF, Email, Idade,
                Dividas, Valor, DataCriacao, DataPagamento, Situacao
            });

            dataGridView1.Location = new Point(-3, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(946, 313);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            // ID da dívida
            ID.HeaderText = "ID Dívida";
            ID.Name = "ID";
            ID.ReadOnly = true;

            // ID do cliente
            IdCliente.HeaderText = "ID Cliente";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;

            // Nome
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;

            // CPF
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;

            // Email
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;

            // Idade
            Idade.HeaderText = "Idade";
            Idade.Name = "Idade";
            Idade.ReadOnly = true;

            // Dívidas
            Dividas.HeaderText = "Dividas";
            Dividas.Name = "Dividas";
            Dividas.ReadOnly = true;

            // Valor
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;

            // Data de criação
            DataCriacao.HeaderText = "Data de Criação";
            DataCriacao.Name = "DataCriacao";
            DataCriacao.ReadOnly = true;

            // Data de pagamento
            DataPagamento.HeaderText = "Data de pagamento";
            DataPagamento.Name = "DataPagamento";
            DataPagamento.ReadOnly = true;

            // Situação
            Situacao.HeaderText = "Situação";
            Situacao.Name = "Situacao";
            Situacao.ReadOnly = true;

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(250, -4);
            label1.Name = "label1";
            label1.Size = new Size(384, 46);
            label1.TabIndex = 1;
            label1.Text = "CONSULTA DE CLIENTES";

            // Excluir
            Excluir.Location = new Point(414, 471);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(85, 32);
            Excluir.TabIndex = 5;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;

            // Sair
            Sair.Location = new Point(12, 12);
            Sair.Name = "Sair";
            Sair.Size = new Size(92, 49);
            Sair.TabIndex = 6;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;

            // txtPesquisa
            txtPesquisa.Location = new Point(453, 66);
            txtPesquisa.Margin = new Padding(3, 2, 3, 2);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(290, 23);
            txtPesquisa.TabIndex = 8;

            // button1
            button1.Location = new Point(748, 64);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 7;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;

            // Anterior
            Anterior.Location = new Point(-3, 423);
            Anterior.Name = "Anterior";
            Anterior.Size = new Size(75, 23);
            Anterior.TabIndex = 9;
            Anterior.Text = "Anterior";
            Anterior.UseVisualStyleBackColor = true;

            // Proximo
            Proximo.Location = new Point(855, 424);
            Proximo.Name = "Proximo";
            Proximo.Size = new Size(75, 23);
            Proximo.TabIndex = 10;
            Proximo.Text = "Próximo";
            Proximo.UseVisualStyleBackColor = true;

            // ConsultarExcluir
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 640);

            Controls.Add(Proximo);
            Controls.Add(Anterior);
            Controls.Add(txtPesquisa);
            Controls.Add(button1);
            Controls.Add(Sair);
            Controls.Add(Excluir);
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn Dividas;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn DataCriacao;
        private DataGridViewTextBoxColumn DataPagamento;
        private DataGridViewTextBoxColumn Situacao;

        private Label label1;
        private Button Excluir;
        private Button Sair;
        private TextBox txtPesquisa;
        private Button button1;
        private Button Anterior;
        private Button Proximo;
    }
}
