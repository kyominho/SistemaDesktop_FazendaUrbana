using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GestaoVendas_FazendaUrbana.UI
{
    public partial class AreaUsuario : Form
    {
        #region Propriedades
        public string nomeNivel;
        DateTime time;
        #endregion

        //construtor do formulario da area do usuario
        public AreaUsuario()
        {
            InitializeComponent();
            frmLogin login = new frmLogin(this);
            login.ShowDialog();
        }

        //carregamento da area de acesso do usuário e verificação se os valores recebidos correspondem a algum valor do banco
        private void AreaUsuariocs_Load(object sender, EventArgs e)
        {

            if (frmLogin.codusuario <= 0)
            {
                MessageBox.Show("Usuário não localizado");
                Close();
                
                
            } 
            
            else { 
            RetornarNomeAcesso();
            

            lblLogado.Text = "Usuário: " + frmLogin.nome + "         Nível de Acesso: " + nomeNivel;

                }
        }

        //configuração do botão de sair do formulário
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Metodos
        //metodo que retorna o nome do nivel de acesso
        public void RetornarNomeAcesso()
        {
            if (frmLogin.nivelacesso == 1)
            {
                nomeNivel = "Administrador";
            }

            else
            {
                nomeNivel = "Funcionário";
            }
        }



        #endregion

        #region Botão
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            // Configura a mensagem, título e botões do MessageBox
            string message = "Deseja realmente sair da aplicação?";
            string caption = "Sair";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            // Exibe o MessageBox e captura o resultado
            result = MessageBox.Show(message, caption, buttons);

            // Verifica qual botão foi clicado
            switch (result)
            {
                case DialogResult.Yes:
                    Close();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void btnEstoqueProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            frmVenda frmVenda = new frmVenda();
            frmVenda.ShowDialog();
        }

        private void lblLogado_Click(object sender, EventArgs e)
        {

        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedor frmFornecedor = new frmFornecedor();
            frmFornecedor.ShowDialog();
        }

        private void btnClienteFisico_Click(object sender, EventArgs e)
        {
            frmClienteFisico frmClienteFisico = new frmClienteFisico();
            frmClienteFisico.ShowDialog();
        }

        private void btnClienteJuridico_Click(object sender, EventArgs e)
        {
            frmClienteJuridico frmClienteJuridico = new frmClienteJuridico();
            frmClienteJuridico.ShowDialog();
        }

        private void btnInsumo_Click(object sender, EventArgs e)
        {
            frmInsumo frmInsumo = new frmInsumo();
            frmInsumo.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto = new frmProduto();
            frmProduto.ShowDialog();
        }


        #endregion

        private void tDataHoraAU_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now;
            lblDataHorarioAU.Text = time.ToLocalTime().ToString();
        }

        private void btnPlantacao_Click(object sender, EventArgs e)
        {
            frmPlantacao frmPlantacao = new frmPlantacao();
            frmPlantacao.ShowDialog();
        }

        private void btnColheita_Click(object sender, EventArgs e)
        {
            frmColheita frmColheita = new frmColheita();
            frmColheita.ShowDialog();
        }
    }
}
