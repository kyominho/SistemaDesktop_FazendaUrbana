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
    
    public partial class frmAddColheita : Form
    {
        #region Instancias
        DAL.ProdutoDAL produtoDAL = new DAL.ProdutoDAL();
        DAL.ColheitaDAL colheitaDAL = new DAL.ColheitaDAL();
        BLL.Colheita colheita = new BLL.Colheita();
        #endregion

        #region Propriedades
        public int codcolheita { get; set; }
        #endregion
        public frmAddColheita()
        {
            InitializeComponent();
        }

        private void btnCadastrarColheita_Click(object sender, EventArgs e)
        {
            try
            {
                colheita.DataColheita = dtpDataColheita.Value;
                colheita.HorarioColheita = dtpHorarioColheita.Value;
                colheita.QuantidadeColheita = Convert.ToInt32(ValidarCampoObrigatorio(txtQuantidadeColhida.Text));
                colheita.CodProdutoC = Convert.ToInt32(cmbProdutos.SelectedValue);



                if (codcolheita > 0)
                    colheitaDAL.Alterar(colheita);


                else
                    colheitaDAL.CadastrarColheita(colheita);
                MessageBox.Show("Dados gravados com sucesso!");
                LimparCampos();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a colheita: " + ex.Message);
                LimparCampos();
            }




        }

        #region metodos
        private void LimparCampos()
        {
            txtQuantidadeColhida.Clear();

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

        private void txtQuantidadeColhida_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }

        private void frmAddColheita_Load(object sender, EventArgs e)
        {
            cmbProdutos.DataSource = produtoDAL.ConsultarTodos();
            cmbProdutos.DisplayMember = "Nome";
            cmbProdutos.ValueMember = "Código";

            if (codcolheita > 0) //editar
            {
                colheita.CodColheita = codcolheita;
                colheita = colheitaDAL.Retornar(colheita);
                dtpDataColheita.Value = colheita.DataColheita;
                dtpHorarioColheita.Value = colheita.HorarioColheita;
                ValidarCampoObrigatorio(txtQuantidadeColhida.Text = colheita.QuantidadeColheita.ToString());
                ValidarCampoObrigatorio(Convert.ToString(cmbProdutos.SelectedValue));

            }
        }
    }
}
