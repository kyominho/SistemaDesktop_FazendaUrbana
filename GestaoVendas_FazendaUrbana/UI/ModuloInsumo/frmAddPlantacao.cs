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
    public partial class frmAddPlantacao : Form
    {

        #region Propriedades
        public int codplantacao { get; set; }
        #endregion

        #region Instancias 
        DAL.PlantacaoDAL plantacaoDAL = new DAL.PlantacaoDAL();
        BLL.Plantacao plantacao = new BLL.Plantacao();
        DAL.InsumoDAL insumoDAL = new DAL.InsumoDAL();
        #endregion

        public frmAddPlantacao()
        {
            InitializeComponent();
        }

        private void btnCadastrarPlantacao_Click(object sender, EventArgs e)
        {
            try
            {
                plantacao.DataPlantacao = dtpDataPlantacao.Value;
                plantacao.HorarioPlantacao = dtpHorarioPlantacao.Value;
                plantacao.QuantidadePlantacao = Convert.ToInt32(ValidarCampoObrigatorio(txtQuantidadePlantada.Text));
                plantacao.CodInsumoP = Convert.ToInt32(cmbInsumos.SelectedValue);



                if (codplantacao > 0)
                    plantacaoDAL.Alterar(plantacao);


                else
                    plantacaoDAL.CadastrarPlantacao(plantacao);
                MessageBox.Show("Dados gravados com sucesso!");
                LimparCampos();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a plantação: " + ex.Message);
                LimparCampos();
            }


        }

        #region metodos
        private void LimparCampos()
        {
            txtQuantidadePlantada.Clear();
 
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

        private void frmAddPlantacao_Load(object sender, EventArgs e)
        {
            cmbInsumos.DataSource = insumoDAL.ConsultarTodos();
            cmbInsumos.DisplayMember = "Nome";
            cmbInsumos.ValueMember = "Código";

            if (codplantacao > 0) //editar
            {
                plantacao.CodPlantacao = codplantacao;
                plantacao = plantacaoDAL.Retornar(plantacao);
                dtpDataPlantacao.Value = plantacao.DataPlantacao;
                dtpHorarioPlantacao.Value = plantacao.HorarioPlantacao;
                ValidarCampoObrigatorio(txtQuantidadePlantada.Text = plantacao.QuantidadePlantacao.ToString());
                ValidarCampoObrigatorio(Convert.ToString(cmbInsumos.SelectedValue));

            }
        }

        private void txtQuantidadePlantada_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImpedirLetrasCaracteresEspeciais(e);
        }
    }
}
