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
            brrEmail = new TextBox();
            email = new Label();
            brrSenha = new TextBox();
            Senha = new Label();
            Entrar = new Button();
            Cancelar = new Button();
            labelMensagem = new Label();
            SuspendLayout();
            // 
            // brrEmail
            // 
            brrEmail.Location = new Point(261, 161);
            brrEmail.Name = "brrEmail";
            brrEmail.Size = new Size(265, 23);
            brrEmail.TabIndex = 0;
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
            // brrSenha
            // 
            brrSenha.Location = new Point(261, 214);
            brrSenha.Name = "brrSenha";
            brrSenha.Size = new Size(265, 23);
            brrSenha.TabIndex = 2;
            brrSenha.UseSystemPasswordChar = true;
            brrSenha.TextChanged += TextBox2_TextChanged;
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
            // labelMensagem
            // 
            labelMensagem.AutoSize = true;
            labelMensagem.Location = new Point(363, 346);
            labelMensagem.Name = "labelMensagem";
            labelMensagem.Size = new Size(0, 15);
            labelMensagem.TabIndex = 6;
            // 
            // Atividade_email_e_senha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMensagem);
            Controls.Add(Cancelar);
            Controls.Add(Entrar);
            Controls.Add(Senha);
            Controls.Add(brrSenha);
            Controls.Add(email);
            Controls.Add(brrEmail);
            Name = "Atividade_email_e_senha";
            Text = "Atividade_email_e_senha";
            Load += Atividade_email_e_senha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox brrEmail;
        private Label email;
        private TextBox brrSenha;
        private Label Senha;
        private Button Entrar;
        private Button Cancelar;
        private Label labelMensagem;
    }
}