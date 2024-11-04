namespace sysTINSApp
{
    partial class FrmLogin
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
            txtSenha = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            btnCancelar = new Button();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 154);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 225);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(173, 172);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(322, 23);
            txtSenha.TabIndex = 2;
            txtSenha.TextChanged += TextBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(193, 322);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(330, 322);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += Button2_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Location = new Point(363, 133);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 6;
            lblMensagem.Click += label3_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(lblMensagem);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(txtSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSenha;
        private TextBox textBox1;
        private Button button1;
        private Button btnCancelar;
        private Label lblMensagem;
    }
}