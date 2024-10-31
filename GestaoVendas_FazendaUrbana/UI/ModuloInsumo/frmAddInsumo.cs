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
    public partial class frmAddInsumo : Form
    {

        #region Instancias
        BLL.Insumo insumo = new BLL.Insumo();
        DAL.InsumoDAL insumoDAL = new DAL.InsumoDAL();
        #endregion

        #region Propriedades
        public int codinsumo { get; set; }
        #endregion
        public frmAddInsumo()
        {
            InitializeComponent();
        }

        private void btnCadastrarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                insumo.NomeInsumo = ValidarCampoObrigatorio(txtNomeInsumo.Text);
                insumo.EstoqueInsumo = Convert.ToInt32(ValidarCampoObrigatorio(txtEstoqueInsumo.Text));
                insumo.DataValidadeInsumo = txtDataValidadeInsumo.Value;
                insumo.PrecoInsumo = Convert.ToDouble(ValidarCampoObrigatorio(txtPrecoInsumo.Text));
                

                if (codinsumo > 0)
                    insumoDAL.Alterar(insumo);


                else
                insumoDAL.CadastrarInsumo(insumo);
                MessageBox.Show("Dados gravados com sucesso!");
                LimparCampos();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o insumo: " + ex.Message);
                LimparCampos();
            }
        }

        private void txtNomeInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirDigitacaoNumero(e);
        }

        private void txtDataValidadeInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }


        #region Metodos

        private void LimparCampos()
        {
            txtNomeInsumo.Clear();
            txtPrecoInsumo.Clear();
            txtEstoqueInsumo.Clear();
            txtNomeInsumo.Focus();
            

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

        private void txtDataValidadeInsumo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmAddInsumo_Load(object sender, EventArgs e)
        {

            if (codinsumo > 0) //editar
            {
                insumo.CodInsumo = codinsumo;
                insumo = insumoDAL.Retornar(insumo);
                ValidarCampoObrigatorio(txtNomeInsumo.Text = insumo.NomeInsumo);
                ValidarCampoObrigatorio(txtEstoqueInsumo.Text = insumo.EstoqueInsumo.ToString());
                txtDataValidadeInsumo.Value = insumo.DataValidadeInsumo;
                ValidarCampoObrigatorio(txtPrecoInsumo.Text = insumo.PrecoInsumo.ToString());
                

            }
        }

        private void txtEstoqueInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

        private void txtPrecoInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEstoqueInsumo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoInsumo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeInsumo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
