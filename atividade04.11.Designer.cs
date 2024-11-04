namespace sysTINSApp
{
    partial class Atividade04
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Nivel = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += TextBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(338, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += TextBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(113, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 23);
            textBox4.TabIndex = 3;
            textBox4.UseSystemPasswordChar = true;
            textBox4.TextChanged += TextBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(265, 185);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(118, 23);
            textBox5.TabIndex = 4;
            textBox5.UseSystemPasswordChar = true;
            textBox5.TextChanged += TextBox5_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(406, 189);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(57, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Ativar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(113, 237);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Inserir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(216, 237);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(317, 237);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Atualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(491, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 68);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 10;
            label1.Text = "ID";
            label1.Click += Label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 68);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 116);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 167);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 13;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 167);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 14;
            label5.Text = "Confirma Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(491, 116);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 15;
            label6.Text = "Nivel";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 68);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 16;
            label7.Text = "Nome";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Email, Nivel, Ativo });
            dataGridView1.Location = new Point(113, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(441, 150);
            dataGridView1.TabIndex = 17;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Nivel
            // 
            Nivel.HeaderText = "Nivel";
            Nivel.Name = "Nivel";
            // 
            // Ativo
            // 
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            // 
            // Atividade04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Atividade04";
            Text = "atividade04";
            Load += Atividade04_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Nivel;
        private DataGridViewTextBoxColumn Ativo;
    }
}