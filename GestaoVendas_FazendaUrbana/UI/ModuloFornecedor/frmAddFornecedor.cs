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

namespace GestaoVendas_FazendaUrbana.UI
{
    public partial class frmAddFornecedor : Form
    {

        public int codfornecedor { get; set; }

        BLL.Fornecedor fornecedor = new BLL.Fornecedor();
        DAL.FornecedorDAL fornecedorDAL = new DAL.FornecedorDAL();
        public frmAddFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedor.NomeFornecedor = ValidarCampoObrigatorio(txtNomeFornecedor.Text);
                fornecedor.EmailFornecedor = ValidarCampoObrigatorio(txtEmailFornecedor.Text);
                fornecedor.UfFornecedor = ValidarCampoObrigatorio(cmbUfFornecedor.Text);
                fornecedor.CidadeFornecedor = ValidarCampoObrigatorio(txtCidadeFornecedor.Text);
                fornecedor.TelefoneFornecedor = ValidarCampoObrigatorio(mskTelefoneFornecedor.Text);
                fornecedor.CepFornecedor = ValidarCampoObrigatorio(mskCepFornecedor.Text);
                fornecedor.LogradouroFornecedor = ValidarCampoObrigatorio(txtLogradouroFornecedor.Text);
                fornecedor.NumeroEnderecoFornecedor = Convert.ToInt16(ValidarCampoObrigatorio(txtNumeroLogradouroF.Text));
                fornecedor.CnpjFornecedor = ValidarCampoObrigatorio(mskCNPJFornecedor.Text);
                fornecedor.RazaoSocialFornecedor = ValidarCampoObrigatorio(txtRazaoSocialFornecedor.Text);

                if (codfornecedor > 0)
                    fornecedorDAL.Alterar(fornecedor);


                else
                fornecedorDAL.CadastrarFornecedor(fornecedor);
                MessageBox.Show("Dados gravados com sucesso!");
                LimparCampos();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o fornecedor: " + ex.Message);
                LimparCampos();
            }
        }

        #region metodos
        private void LimparCampos()
        {

            txtNomeFornecedor.Clear();
            txtEmailFornecedor.Clear();
            txtLogradouroFornecedor.Clear();
            mskCepFornecedor.Clear();
            mskCNPJFornecedor.Clear();
            mskTelefoneFornecedor.Clear();
            txtCidadeFornecedor.Clear();
            txtNumeroLogradouroF.Clear();
            txtRazaoSocialFornecedor.Clear();


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



        private void txtNomeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirDigitacaoNumero(e);
        }

        private void mskTelefoneFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

        private void txtRazaoSocialFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirDigitacaoNumero(e);
        }

        private void txtEmailFornecedor_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox txtEmailFornecedor = sender as TextBox;

                var validacaoEmail = ValidarEmail(txtEmailFornecedor.Text);

                if (!validacaoEmail)
                {
                    MessageBox.Show("Email inválido!");
                    txtEmailFornecedor.Focus();
                }

            }

            catch (Exception)
            {
                throw;
            }
        }

        private void frmAddFornecedor_Load(object sender, EventArgs e)
        {
            //cmbUfFornecedor.SelectedIndex = 0;

            if (codfornecedor > 0) //editar
            {
                fornecedor.CodFornecedor = codfornecedor;
                fornecedor = fornecedorDAL.Retornar(fornecedor);
                ValidarCampoObrigatorio(txtNomeFornecedor.Text = fornecedor.NomeFornecedor);
                ValidarCampoObrigatorio(txtEmailFornecedor.Text = fornecedor.EmailFornecedor);
                ValidarCampoObrigatorio(cmbUfFornecedor.Text = fornecedor.UfFornecedor);
                ValidarCampoObrigatorio(txtCidadeFornecedor.Text = fornecedor.CidadeFornecedor);
                ValidarCampoObrigatorio(mskTelefoneFornecedor.Text = fornecedor.TelefoneFornecedor);
                ValidarCampoObrigatorio(mskCepFornecedor.Text = fornecedor.CepFornecedor);
                ValidarCampoObrigatorio(txtLogradouroFornecedor.Text = fornecedor.LogradouroFornecedor);
                ValidarCampoObrigatorio(txtNumeroLogradouroF.Text = fornecedor.NumeroEnderecoFornecedor.ToString());
                ValidarCampoObrigatorio(mskCNPJFornecedor.Text = fornecedor.CnpjFornecedor);
                ValidarCampoObrigatorio(txtRazaoSocialFornecedor.Text = fornecedor.RazaoSocialFornecedor);


            }
        }

        private void mskCepFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

        private void txtNumeroLogradouroF_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

 
    }
}
