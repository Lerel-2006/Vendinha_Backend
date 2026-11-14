namespace Vendinha.Desktop.Screens
{
    partial class Atualizar
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
            button1 = new Button();
            AtualizarDbox = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(189, 88);
            label1.Name = "label1";
            label1.Size = new Size(543, 46);
            label1.TabIndex = 0;
            label1.Text = "Escolha o que você deseja atualizar";
            // 
            // button1
            // 
            button1.Location = new Point(235, 212);
            button1.Name = "button1";
            button1.Size = new Size(152, 63);
            button1.TabIndex = 3;
            button1.Text = "Atualizar Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AtualizarDbox
            // 
            AtualizarDbox.Location = new Point(541, 212);
            AtualizarDbox.Name = "AtualizarDbox";
            AtualizarDbox.Size = new Size(152, 63);
            AtualizarDbox.TabIndex = 4;
            AtualizarDbox.Text = "Atualizar Dívida";
            AtualizarDbox.UseVisualStyleBackColor = true;
            // 
            // Atualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 487);
            Controls.Add(AtualizarDbox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Atualizar";
            Text = "Atualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button AtualizarDbox;
    }
}