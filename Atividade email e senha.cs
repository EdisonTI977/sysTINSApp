namespace sysTINSApp
{
    public partial class Atividade_email_e_senha : Form
    {
        public Atividade_email_e_senha()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atividade_email_e_senha_Load(object sender, EventArgs e)
        {
            // colocar a validação do login
            _ = EfetuarLogin(brrEmail.Text, brrSenha.Text);
            if (Usuario.Id > 0)
            {

                Close();

            }
            else
            {
                labelMensagem.Text = "Usuário e/ou senha inválidos";


            }
        }

        private object EfetuarLogin(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }

    internal class Usuario
    {
        public static int Id { get; internal set; }
    }
}
