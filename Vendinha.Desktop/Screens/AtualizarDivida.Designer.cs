namespace Vendinha.Desktop.Screens
{
    partial class AtualizarDivida
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
            IdBox = new TextBox();
            label6 = new Label();
            Voltar = new Button();
            Confirmar = new Button();
            label2 = new Label();
            label4 = new Label();
            NomeDivida = new TextBox();
            label3 = new Label();
            pickerData = new DateTimePicker();
            label5 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            NomeBox = new TextBox();
            label7 = new Label();
            IdDividaBox = new TextBox();
            label8 = new Label();
            Valor = new TextBox();
            SuspendLayout();
            // 
            // Valor
            // 
            Valor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Valor.ForeColor = Color.Gray;
            Valor.HideSelection = false;
            Valor.Location = new Point(350, 157);
            Valor.Name = "Valor";
            Valor.Size = new Size(276, 23);
            Valor.TabIndex = 41;
            Valor.Text = "R$";
            // 
            // IdBox
            // 
            IdBox.Location = new Point(20, 97);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(290, 23);
            IdBox.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(20, 73);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 36;
            label6.Text = "Id do Cliente";
            // 
            // Voltar
            // 
            Voltar.Location = new Point(523, 418);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(99, 31);
            Voltar.TabIndex = 35;
            Voltar.Text = "Voltar";
            Voltar.UseVisualStyleBackColor = true;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(350, 418);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(97, 31);
            Confirmar.TabIndex = 34;
            Confirmar.Text = "Atualizar";
            Confirmar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28F);
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(298, 51);
            label2.TabIndex = 25;
            label2.Text = "Atualizar Dívidas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(350, 133);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 40;
            label4.Text = "Valor";
            // 
            // NomeDivida
            // 
            NomeDivida.Location = new Point(350, 97);
            NomeDivida.Name = "NomeDivida";
            NomeDivida.Size = new Size(276, 23);
            NomeDivida.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(350, 73);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 38;
            label3.Text = "Nome da Dívida";
            // 
            // pickerData
            // 
            pickerData.Format = DateTimePickerFormat.Short;
            pickerData.Location = new Point(350, 221);
            pickerData.Margin = new Padding(2);
            pickerData.Name = "pickerData";
            pickerData.ShowCheckBox = true;
            pickerData.Size = new Size(290, 23);
            pickerData.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(350, 198);
            label5.Name = "label5";
            label5.Size = new Size(145, 21);
            label5.TabIndex = 42;
            label5.Text = "Data de Pagamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(664, 79);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 44;
            label1.Text = "Situação";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(673, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(52, 19);
            checkBox1.TabIndex = 45;
            checkBox1.Text = "Paga";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(673, 124);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(80, 19);
            checkBox2.TabIndex = 46;
            checkBox2.Text = "Em aberto";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // NomeBox
            // 
            NomeBox.Location = new Point(20, 161);
            NomeBox.Name = "NomeBox";
            NomeBox.Size = new Size(290, 23);
            NomeBox.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(20, 137);
            label7.Name = "label7";
            label7.Size = new Size(127, 21);
            label7.TabIndex = 47;
            label7.Text = "Nome do Cliente";
            // 
            // IdDividaBox
            // 
            IdDividaBox.Location = new Point(20, 222);
            IdDividaBox.Name = "IdDividaBox";
            IdDividaBox.Size = new Size(290, 23);
            IdDividaBox.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(20, 198);
            label8.Name = "label8";
            label8.Size = new Size(71, 21);
            label8.TabIndex = 49;
            label8.Text = "Id Divida";
            // 
            // AtualizarDivida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 502);
            Controls.Add(IdDividaBox);
            Controls.Add(label8);
            Controls.Add(NomeBox);
            Controls.Add(label7);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(pickerData);
            Controls.Add(label5);
            Controls.Add(Valor);
            Controls.Add(label4);
            Controls.Add(NomeDivida);
            Controls.Add(label3);
            Controls.Add(IdBox);
            Controls.Add(label6);
            Controls.Add(Voltar);
            Controls.Add(Confirmar);
            Controls.Add(label2);
            Name = "AtualizarDivida";
            Text = "+";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IdBox;
        private Label label6;
        private Button Voltar;
        private Button Confirmar;
        private Label label2;
        private Label label4;
        private TextBox NomeDivida;
        private Label label3;
        private DateTimePicker pickerData;
        private Label label5;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox NomeBox;
        private Label label7;
        private TextBox IdDividaBox;
        private Label label8;
        private TextBox Valor;
    }
}