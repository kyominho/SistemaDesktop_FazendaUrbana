using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoVendas_FazendaUrbana.BLL;
using GestaoVendas_FazendaUrbana.DAL;

namespace GestaoVendas_FazendaUrbana.UI.ModuloCliente
{
    public partial class frmAddClienteFisico : Form
    {
        #region Propriedades
        public int codclientefisico { get; set; }

        #endregion

        #region Instancias
        BLL.Cliente cliente = new BLL.Cliente();
        BLL.ClienteFisico clienteFisico = new BLL.ClienteFisico();
        DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
        #endregion

        #region Construtor
        public frmAddClienteFisico()
        {
            InitializeComponent();
        }
#endregion

        private void frmAddClienteFisico_Load(object sender, EventArgs e)
        {
            cmbNomeClienteF.DataSource = clienteDAL.ConsultarTodos();
            cmbNomeClienteF.DisplayMember = "Nome";
            cmbNomeClienteF.ValueMember = "Código";

            if (codclientefisico > 0) //editar
            {
                clienteFisico.CodClienteFisico = codclientefisico;
                clienteFisico = clienteDAL.RetornarClienteFisico(clienteFisico);
                ValidarCampoObrigatorio(mskCpfCliente.Text = clienteFisico.CpfCliente);
                ValidarCampoObrigatorio(Convert.ToString(cmbNomeClienteF.SelectedValue));

            }


        }

        private void btnCadastrarClienteF_Click(object sender, EventArgs e)
        {
            try
            {
                clienteFisico.CpfCliente = ValidarCampoObrigatorio(mskCpfCliente.Text);
                clienteFisico.CodClienteF = Convert.ToInt16(cmbNomeClienteF.SelectedValue);
               
                if (codclientefisico > 0)
                    clienteDAL.AlterarClienteFisico(clienteFisico);


                else
                clienteDAL.CadastrarClienteFisico(clienteFisico);
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
            mskCpfCliente.Clear();

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

    }
}
