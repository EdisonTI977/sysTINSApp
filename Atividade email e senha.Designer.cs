namespace sysTINSApp
{
    partial class Atividade_email_e_senha
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
            textBox1 = new TextBox();
            email = new Label();
            textBox2 = new TextBox();
            Senha = new Label();
            Entrar = new Button();
            Cancelar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 23);
            textBox1.TabIndex = 0;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(261, 143);
            email.Name = "email";
            email.Size = new Size(36, 15);
            email.TabIndex = 1;
            email.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 23);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(261, 196);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 3;
            Senha.Text = "Senha";
            // 
            // Entrar
            // 
            Entrar.Location = new Point(274, 266);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(75, 23);
            Entrar.TabIndex = 4;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(400, 266);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 5;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // Atividade_email_e_senha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancelar);
            Controls.Add(Entrar);
            Controls.Add(Senha);
            Controls.Add(textBox2);
            Controls.Add(email);
            Controls.Add(textBox1);
            Name = "Atividade_email_e_senha";
            Text = "Atividade_email_e_senha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label email;
        private TextBox textBox2;
        private Label Senha;
        private Button Entrar;
        private Button Cancelar;
    }
}