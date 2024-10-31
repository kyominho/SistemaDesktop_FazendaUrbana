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
    public partial class frmAddUsuario : Form
    {
        #region Propriedades
        public int codusuario { get; set; }
        #endregion

        #region Instancias
        BLL.Usuario usuario = new BLL.Usuario();
        DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();
        #endregion
        public frmAddUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.NomeUsuario = ValidarCampoObrigatorio(txtNomeUsuario.Text);
                usuario.NivelAcesso = Convert.ToInt16(ValidarCampoObrigatorio(cbxNivelAcesso.Text));
                usuario.User = ValidarCampoObrigatorio(txtUsuario.Text);
                usuario.Senha = ValidarCampoObrigatorio(txtSenha.Text);

                if (codusuario > 0)
                   usuarioDAL.Alterar(usuario);
                

                else
                usuarioDAL.CadastrarUsuario(usuario);
                MessageBox.Show("Dados gravados com sucesso!");
                LimparCampos();
           

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o cliente: " + ex.Message);
                LimparCampos();
            }
        }


        #region Metodos

        private void LimparCampos()
        {
            txtNomeUsuario.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtNomeUsuario.Focus();

        }

        private void ImpedirDigitacaoNumero(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private string ValidarCampoObrigatorio(string texto)
        {
            try
            {
                if (String.IsNullOrEmpty(texto))
                {
                    MessageBox.Show("Campo Obrigatório");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return texto;
        }

        #endregion


        private void txtNomeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirDigitacaoNumero(e);
        }

        private void frmAddUsuario_Load(object sender, EventArgs e)
        {


            if (codusuario > 0) //editar
            {
                usuario.CodUsuario = codusuario;
                usuario = usuarioDAL.Retornar(usuario);
                ValidarCampoObrigatorio(txtNomeUsuario.Text = usuario.NomeUsuario);
                ValidarCampoObrigatorio(cbxNivelAcesso.Text = usuario.NivelAcesso.ToString());
                ValidarCampoObrigatorio(txtUsuario.Text = usuario.User);
                ValidarCampoObrigatorio(txtSenha.Text = usuario.Senha);

            }
        }
    }

}

