using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoVendas_FazendaUrbana.BLL;
using GestaoVendas_FazendaUrbana.DAL;

namespace GestaoVendas_FazendaUrbana
{

    public partial class frmAddCliente : Form
    {
        #region Instancias
        BLL.Cliente cliente = new BLL.Cliente();
        DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
        #endregion

        #region Propriedades 
        public int codcliente { get; set; }

        #endregion

        #region Construtor
        public frmAddCliente()
        {
            InitializeComponent();
        }
        #endregion

        #region Evento do Botao Cadastrar
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.NomeCliente = ValidarCampoObrigatorio(txtNomeCliente.Text);
                cliente.EmailCliente = ValidarCampoObrigatorio (txtEmailCliente.Text);
                cliente.UFCliente = ValidarCampoObrigatorio (cmbUF.Text);
                cliente.CidadeCliente = ValidarCampoObrigatorio (txtCidadeCliente.Text);
                cliente.TelefoneCliente = ValidarCampoObrigatorio (mskTelefoneCliente.Text);
                cliente.CepCliente = ValidarCampoObrigatorio (mskCepCliente.Text);
                cliente.LogradouroCliente = ValidarCampoObrigatorio(txtLogradouroCliente.Text);
                cliente.NumEnderecoCliente = Convert.ToInt32(ValidarCampoObrigatorio(txtNumeroLCliente.Text));

                if (codcliente > 0)
                    clienteDAL.Alterar(cliente);


                else
                    clienteDAL.CadastrarCliente(cliente);
                MessageBox.Show("Dados gravados com sucesso!");
                LimparCampos();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o cliente: " + ex.Message);
                LimparCampos();
            }
        }

        #endregion


        #region Metodos de Validação

        private void LimparCampos()
        {

            txtNomeCliente.Clear();
            txtEmailCliente.Clear();
            txtCidadeCliente.Clear();
            mskTelefoneCliente.Clear();
            cmbUF.Items.Clear();
            mskCepCliente.Clear();
            txtLogradouroCliente.Clear();
            txtLogradouroCliente.Clear();
            txtNumeroLCliente.Clear();


        }

        private bool ValidarEmail(string email)
        {
            try {
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

        #region Eventos Componentes

        private void mskTelefoneCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                MaskedTextBox mskTelefoneCliente = sender as MaskedTextBox;
                var validacaoTelefone = ValidarTelefone(mskTelefoneCliente.Text);
                if (!validacaoTelefone)
                {
                    MessageBox.Show("Telefone inválido");
                    mskTelefoneCliente.Focus();
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirDigitacaoNumero(e);
        }

        private void txtNumeroLCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

        private void txtCidadeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirDigitacaoNumero(e);
        }

        private void mskCepCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            cmbUF.SelectedIndex = 0;

            if (codcliente > 0) //editar
            {
                cliente.CodCliente = codcliente;
                cliente = clienteDAL.Retornar(cliente);
                ValidarCampoObrigatorio(txtNomeCliente.Text = cliente.NomeCliente);
                ValidarCampoObrigatorio(txtEmailCliente.Text = cliente.EmailCliente);
                ValidarCampoObrigatorio(cmbUF.Text = cliente.UFCliente);
                ValidarCampoObrigatorio(txtCidadeCliente.Text = cliente.CidadeCliente);
                ValidarCampoObrigatorio(mskTelefoneCliente.Text = cliente.TelefoneCliente);
                ValidarCampoObrigatorio(mskCepCliente.Text = cliente.CepCliente);
                ValidarCampoObrigatorio(txtLogradouroCliente.Text = cliente.LogradouroCliente);
                ValidarCampoObrigatorio(txtNumeroLCliente.Text = cliente.NumEnderecoCliente.ToString());


            }
        }

        private void txtEmailCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txtEmailCliente = sender as TextBox;

                var validacaoEmail = ValidarEmail(txtEmailCliente.Text);

                if (!validacaoEmail)
                {
                    MessageBox.Show("Email inválido!");
                    txtEmailCliente.Focus();
                }

            }

            catch (Exception)
            {
                throw;
            }
        }

        #endregion

   
    }

}


