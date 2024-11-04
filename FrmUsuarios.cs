using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysTINSClass;

internal static object UsuarioLogado;

object UsuarioLogado { get; internal set; }

namespace sysTINSApp
{
    public partial class FrmUsuarios : Form
    {
        private object dgvUsuarios;

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

            int linhaAtual = dgvUsuarios.CurrentRow.Index;
            int idUser = int.Parse(dgvUsuarios.Rows[linhaAtual].Cells[0].Value);
            var usuario = usuario.ObterPorId(idUser);
            //MessageBox.Show(idUser.ToString());
            txtId.Text = usuario.Id.ToString();
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            chkAtivo.Checked = usuario.Ativo;
            cmbNivel.SelectedIndex = usuario.Nivel.Id;
            btnAtualizar.Enabled = true;

            Private void btnAtualizar_Click(Projection sender, EventArgs e)

                Usuario usuario = new()
                {
                    Id = int.Parse(txtId.Text),
                    Nome = txtNome.Text,
                    Senha = txtSenha.Text,
                    Nivel = Nivel.ObterPorId(Convert.ToInt32(cmbNivep.SelectedValue))
                };
            {
                CarregaGridUsuarios();
                MessageBox.Show("Usuário atualizado com sucesso!");

            }


        }

        private void CarregaGridUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}

    {


    }



