using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoVendas_FazendaUrbana.UI
{
    public partial class frmUsuario : Form
    {
        #region Instancias
        BLL.Usuario usuario = new BLL.Usuario();    
        DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();
        #endregion
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnFrmCadastrarUsuario_Click(object sender, EventArgs e)
        {
            frmAddUsuario addUsuario = new frmAddUsuario();
            addUsuario.ShowDialog();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            //dgvConsulta.DataSource = cliDAL.ConsultarTodos();
            dgvUsuario.DataSource = usuarioDAL.ConsultarTodos();
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.RowCount > 0)
            {
                

                if (MessageBox.Show("Deseja realmente excluir o usuário?", "Excluir", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    usuario.CodUsuario = Convert.ToInt32(dgvUsuario[0, dgvUsuario.CurrentRow.Index].Value);

                    //chamando metodo de excluir

                    usuarioDAL.Excluir(usuario);

                    //atualizando a tabela (consulta)
                    dgvUsuario.DataSource = usuarioDAL.ConsultarTodos();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.RowCount > 0)
            {

                frmAddUsuario addUsuario = new frmAddUsuario();
                addUsuario.codusuario = Convert.ToInt32(dgvUsuario[0, dgvUsuario.CurrentRow.Index].Value);
                addUsuario.ShowDialog();
                dgvUsuario.DataSource = usuarioDAL.ConsultarTodos();


            }

        }

        private void btnFiltrarNomeUsuario_Click(object sender, EventArgs e)
        {
            usuario.NomeUsuario = txtPesquisarUsuario.Text;
            dgvUsuario.DataSource = usuarioDAL.FiltrarPorNome(usuario);
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisarUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
