#pragma warning disable IDE0005 // O uso da diretiva é desnecessário.
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//#pragma warning restore IDE0005 // O uso da diretiva é desnecessário.
//using SysTINSClass;
//namespace sysTINSApp
//{
//    public partial class FrmPrincipal : Form
//    {
//        public FrmPrincipal()
//        {
//            InitializeComponent();
//        }

//        private void FrmPrincipal_Load(object sender, EventArgs e)
//        {

//        }

//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Estilos de Nomenclatura", Justification = "<Pendente>")]
//        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
//        {

//        }

//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Estilos de Nomenclatura", Justification = "<Pendente>")]
//        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
//        {

//        }

//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Estilos de Nomenclatura", Justification = "<Pendente>")]
//        private void digiteAquiToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//        }

//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Estilos de Nomenclatura", Justification = "<Pendente>")]
//        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//        }

//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Estilos de Nomenclatura", Justification = "<Pendente>")]
//        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//        }

//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0017:Simplificar a inicialização de objeto", Justification = "<Pendente>")]
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Estilos de Nomenclatura", Justification = "<Pendente>")]
//        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
//        {
//            FrmUsuarios frmUsuarios = new();
//            frmUsuarios.MdiParent = this;
//            frmUsuarios.Show();

//        }
//    }
//    var cmd = Banco.Abrir();
//    cmd.CommandText ="select * from niveis where id = 1";
//        var dr = cmd.ExecuteReader();
////   if (dr.Read())
//}
//MessageBox.Show($" olá "{dr.GetString}
