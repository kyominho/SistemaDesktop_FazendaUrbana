using GestaoVendas_FazendaUrbana.BLL;
using GestaoVendas_FazendaUrbana.DAL;
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
    public partial class frmAddProduto : Form
    {

        #region Instancias
        DAL.ProdutoDAL produtoDAL = new DAL.ProdutoDAL();
        BLL.Produto produto = new BLL.Produto();
        #endregion

        #region Propriedades
        public int codproduto { get; set; }
        #endregion

        public frmAddProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                produto.NomeProduto = ValidarCampoObrigatorio(txtNomeProduto.Text);
                produto.PrecoProduto = Convert.ToDouble(ValidarCampoObrigatorio(txtPrecoProduto.Text));
                produto.EstoqueProduto = Convert.ToInt32(ValidarCampoObrigatorio(txtEstoqueProduto.Text));
                produto.DataValidadeProduto = dtpDataValidadeProduto.Value;



                if (codproduto > 0)
                    produtoDAL.Alterar(produto);


                else
                    produtoDAL.CadastrarProduto(produto);
                MessageBox.Show("Dados gravados com sucesso!");
                LimparCampos();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o produto: " + ex.Message);
                LimparCampos();
            }
        }

        #region Metodos

        private void LimparCampos()
        {
            txtNomeProduto.Clear();
            txtPrecoProduto.Clear();
            txtEstoqueProduto.Clear();
            txtNomeProduto.Focus();

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

        private void ImpedirLetrasCaracteresEspeciais(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }









        #endregion

        private void frmAddProduto_Load(object sender, EventArgs e)
        {
            if (codproduto > 0) //editar
            {
                produto.CodProduto = codproduto;
                produto = produtoDAL.Retornar(produto);
                ValidarCampoObrigatorio(txtNomeProduto.Text = produto.NomeProduto);
                ValidarCampoObrigatorio(txtPrecoProduto.Text = produto.PrecoProduto.ToString());
                ValidarCampoObrigatorio(txtEstoqueProduto.Text = produto.EstoqueProduto.ToString());
                dtpDataValidadeProduto.Value = produto.DataValidadeProduto;

            }
        }

        private void txtNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirDigitacaoNumero(e);
        }

        private void txtPrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

        private void txtEstoqueProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }
    }
}
