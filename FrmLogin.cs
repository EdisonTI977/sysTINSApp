namespace sysTINSApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new();
            frmPrincipal.Show();
            Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // colocar a validação do login
            var Usuario = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuario.Id > 0)
            {

                Close();

            }
            else
            {
                lblMensagem.Text = "Usuário e/ou senha inválidos";


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
