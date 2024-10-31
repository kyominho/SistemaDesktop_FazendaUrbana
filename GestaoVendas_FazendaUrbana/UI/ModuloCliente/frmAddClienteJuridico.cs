using GestaoVendas_FazendaUrbana.BLL;
using GestaoVendas_FazendaUrbana.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoVendas_FazendaUrbana.UI.ModuloCliente
{
    public partial class frmAddClienteJuridico : Form
    {
        #region Propriedades
        public int codclientejuridico { get; set; }

        #endregion

        #region Instancias
        BLL.Cliente cliente = new BLL.Cliente();
        BLL.ClienteJuridico clienteJuridico = new BLL.ClienteJuridico();
        DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
        #endregion

        #region Construtor
        public frmAddClienteJuridico()
        {
            InitializeComponent();
        }
        #endregion

        private void btnCadastrarClienteJ_Click(object sender, EventArgs e)
        {
            try
            {
                clienteJuridico.CnpjCliente = ValidarCampoObrigatorio(mskCNPJClienteJuridico.Text);
                clienteJuridico.RazaoSocialCliente = ValidarCampoObrigatorio(txtRazaoSocialCliente.Text);
                clienteJuridico.CodClienteJ = Convert.ToInt32(cmbNomeClienteJ.SelectedValue);

                if (codclientejuridico > 0)
                    clienteDAL.AlterarClienteJuridico(clienteJuridico);


                else
                    clienteDAL.CadastrarClienteJuridico(clienteJuridico);
                MessageBox.Show("Dados gravados com sucesso!");
                LimparCampos();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o cliente: " + ex.Message);
                LimparCampos();
            }

        }

        #region Metodos de Validação

        private void LimparCampos()
        {
            mskCNPJClienteJuridico.Clear();
            

        }

        private bool ValidarEmail(string email)
        {
            try
            {
                string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (string.IsNullOrEmpty(email))
                {
                    return false;
                }

                Regex regex = new Regex(emailPattern);
                return regex.IsMatch(email);
            }

            catch (Exception)
            {
                throw;
            }


        }

        private bool ValidarTelefone(string telefone)
        {
            bool validacaoTelefone = false;
            try
            {
                string padraoTelefone = @"(\(?\d{2}\)?\s)?(\d{4,5}\-\d{4})";

                if (string.IsNullOrEmpty(telefone))
                {
                    return false;
                }

                Match resultado = Regex.Match(telefone, padraoTelefone);

                if (resultado.Success)
                {
                    validacaoTelefone = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return validacaoTelefone;
        }

        private void ImpedirDigitacaoNumero(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void ImpedirLetrasCaracteresEspeciais(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
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

        #region Eventos dos Componentes
        private void frmAddClienteJuridico_Load(object sender, EventArgs e)
        {
            cmbNomeClienteJ.DataSource = clienteDAL.ConsultarTodos();
            cmbNomeClienteJ.DisplayMember = "Nome";
            cmbNomeClienteJ.ValueMember = "Código";

            if (codclientejuridico > 0) //editar
            {
                clienteJuridico.CodClienteJuridico = codclientejuridico;
                clienteJuridico = clienteDAL.RetornarClienteJuridico(clienteJuridico);
                ValidarCampoObrigatorio(mskCNPJClienteJuridico.Text = clienteJuridico.CnpjCliente);
                ValidarCampoObrigatorio(txtRazaoSocialCliente.Text = clienteJuridico.RazaoSocialCliente);
                ValidarCampoObrigatorio(Convert.ToString(cmbNomeClienteJ.SelectedValue));

                //ValidarCampoObrigatorio(cmbNomeClienteJ.Text = clienteJuridico.CodClienteJ.ToString());
         

            }
        }

        private void mskCNPJClienteJuridico_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

        private void txtRazaoSocialCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirDigitacaoNumero(e);
        }

        #endregion
    }
}
