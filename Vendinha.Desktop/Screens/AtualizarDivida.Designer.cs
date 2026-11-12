namespace Vendas.Screens
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
            TextBox Valor;
            textBox1 = new TextBox();
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
            Valor = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(20, 73);
            label6.Name = "label6";
            label6.Size = new Size(27, 21);
            label6.TabIndex = 36;
            label6.Text = "Id ";
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
            label2.Click += label2_Click;
            // 
            // Valor
            // 
            Valor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Valor.ForeColor = Color.Gray;
            Valor.HideSelection = false;
            Valor.Location = new Point(20, 221);
            Valor.Name = "Valor";
            Valor.Size = new Size(276, 23);
            Valor.TabIndex = 41;
            Valor.Text = "R$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(20, 197);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 40;
            label4.Text = "Valor";
            // 
            // NomeDivida
            // 
            NomeDivida.Location = new Point(20, 161);
            NomeDivida.Name = "NomeDivida";
            NomeDivida.Size = new Size(276, 23);
            NomeDivida.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(20, 137);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 38;
            label3.Text = "Nome da Dívida";
            // 
            // pickerData
            // 
            pickerData.Format = DateTimePickerFormat.Short;
            pickerData.Location = new Point(20, 294);
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
            label5.Location = new Point(20, 271);
            label5.Name = "label5";
            label5.Size = new Size(145, 21);
            label5.TabIndex = 42;
            label5.Text = "Data de Pagamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(430, 92);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 44;
            label1.Text = "Situação";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(439, 114);
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
            checkBox2.Location = new Point(439, 137);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(80, 19);
            checkBox2.TabIndex = 46;
            checkBox2.Text = "Em aberto";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // AtualizarDivida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 502);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(pickerData);
            Controls.Add(label5);
            Controls.Add(Valor);
            Controls.Add(label4);
            Controls.Add(NomeDivida);
            Controls.Add(label3);
            Controls.Add(textBox1);
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

        private TextBox textBox1;
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
    }
}