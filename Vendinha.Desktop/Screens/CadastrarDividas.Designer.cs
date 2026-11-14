namespace Vendinha.Desktop.Screens
{
    partial class CadastrarDividas
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
            label1 = new Label();
            label2 = new Label();
            NomeCliente = new TextBox();
            NomeDivida = new TextBox();
            label3 = new Label();
            label4 = new Label();
            DataCriacao = new DateTimePicker();
            label6 = new Label();
            Confirmar = new Button();
            Limpar = new Button();
            Sair = new Button();
            idbox = new TextBox();
            Id = new Label();
            Valor = new TextBox();
            SuspendLayout();
            // 
            // Valor
            // 
            Valor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Valor.ForeColor = Color.Gray;
            Valor.HideSelection = false;
            Valor.Location = new Point(12, 256);
            Valor.Name = "Valor";
            Valor.Size = new Size(276, 23);
            Valor.TabIndex = 6;
            Valor.Text = "R$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(-6, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 54);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Dívida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome do Cliente";
            // 
            // NomeCliente
            // 
            NomeCliente.Location = new Point(12, 139);
            NomeCliente.Name = "NomeCliente";
            NomeCliente.Size = new Size(276, 23);
            NomeCliente.TabIndex = 2;
            // 
            // NomeDivida
            // 
            NomeDivida.Location = new Point(12, 196);
            NomeDivida.Name = "NomeDivida";
            NomeDivida.Size = new Size(276, 23);
            NomeDivida.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 172);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 3;
            label3.Text = "Nome da Dívida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 232);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 5;
            label4.Text = "Valor";
            // 
            // DataCriacao
            // 
            DataCriacao.Format = DateTimePickerFormat.Short;
            DataCriacao.Location = new Point(12, 317);
            DataCriacao.Margin = new Padding(2);
            DataCriacao.Name = "DataCriacao";
            DataCriacao.Size = new Size(269, 23);
            DataCriacao.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 294);
            label6.Name = "label6";
            label6.Size = new Size(119, 21);
            label6.TabIndex = 11;
            label6.Text = "Data de Criação";
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(384, 434);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(104, 39);
            Confirmar.TabIndex = 15;
            Confirmar.Text = "Cadastrar ";
            Confirmar.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(537, 434);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(104, 39);
            Limpar.TabIndex = 16;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            // 
            // Sair
            // 
            Sair.Location = new Point(696, 434);
            Sair.Name = "Sair";
            Sair.Size = new Size(104, 39);
            Sair.TabIndex = 17;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            // 
            // idbox
            // 
            idbox.Location = new Point(12, 89);
            idbox.Name = "idbox";
            idbox.Size = new Size(276, 23);
            idbox.TabIndex = 19;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Font = new Font("Segoe UI", 12F);
            Id.Location = new Point(12, 65);
            Id.Name = "Id";
            Id.Size = new Size(25, 21);
            Id.TabIndex = 18;
            Id.Text = "ID";
            // 
            // CadastrarDividas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 521);
            Controls.Add(idbox);
            Controls.Add(Id);
            Controls.Add(Sair);
            Controls.Add(Limpar);
            Controls.Add(Confirmar);
            Controls.Add(DataCriacao);
            Controls.Add(label6);
            Controls.Add(Valor);
            Controls.Add(label4);
            Controls.Add(NomeDivida);
            Controls.Add(label3);
            Controls.Add(NomeCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastrarDividas";
            Text = "CadastrarDividas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NomeCliente;
        private TextBox NomeDivida;
        private TextBox Valor;
        private Label label3;
        private Label label4;
        private DateTimePicker DataCriacao;
        private Label label6;
        private Button Confirmar;
        private Button Limpar;
        private Button Sair;
        private TextBox idbox;
        private Label Id;
    }
}