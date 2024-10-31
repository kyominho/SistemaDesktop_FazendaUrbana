using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoVendas_FazendaUrbana.UI
{
    public partial class frmLogin : Form
    {

        //se comunica com o formulario da area do funcionario
        AreaUsuario areaUsuario;

        #region InstanciasClasses
        BLL.Usuario usuario = new BLL.Usuario();
        DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();
        #endregion


        #region Propriedades
        public static string nome;
        public static int codusuario;
        public static int nivelacesso;
        DateTime time;
        #endregion

        //construtor
        public frmLogin(AreaUsuario au)
        {
            InitializeComponent();
            areaUsuario = au;
        }

        //evento do clique do botão entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                //recebendo valores das textboxs
                usuario.User = txtUsuario.Text;
                usuario.Senha = txtSenha.Text;

                //verificando se usuário e senha estão vazios
                if (usuario.User == "" || usuario.Senha == "")
                {
                    MessageBox.Show("E-mail ou senha inválidos!");
                    LimparCampos();
                    return;
                }

                //efetuando o login
                    usuarioDAL.Logar(usuario);
                    codusuario = usuario.CodUsuario;
                    nome = usuario.NomeUsuario;
                    nivelacesso = usuario.NivelAcesso;
                    Close();
                

            }

            //pegar exeções de erros relacionados ao banco de dados
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao efetuar login: " + ex.Message);

            }

        }
        #region Metodos

        //limpar campos do formulario 
        public void LimparCampos()
        {

            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();


        }
        
        //sair da aplicação
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        #endregion

        private void painelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tHorarioData_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            lblHorarioData.Text = time.ToLocalTime().ToString();
        }
    }
}
