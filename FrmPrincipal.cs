using sysTINSApp;

namespace SysTINSApp
{
    public partial class FrmPrincipal : Form
    {
        private readonly object tsslUsuario;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void NovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new();// cria uma instância (objeto) do FrmUsuarios 
            FrmUsuarios frmUsuarios1 = frmUsuarios;
            frmUsuarios1.MdiParent = this; // associa esta instância ao container (MDI) FrmPrincipal
            frmUsuarios.Show(); // exibe o form Usuários na janela do sistema 
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Hide();
            FrmLogin frmLogin = new();
            //frmLogin.Show();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                tsslUsuario.Text = Program.UsuarioLogado.Nome + " - " + Program.UsuarioLogado.Nivel.Nome;
                Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}