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
    public partial class frmPlantacao : Form
    {

        #region Instancias
        DAL.PlantacaoDAL plantacaoDAL = new DAL.PlantacaoDAL();
        BLL.Plantacao plantacao = new BLL.Plantacao();
        DAL.InsumoDAL insumoDAL = new DAL.InsumoDAL();
        BLL.Insumo insumo = new BLL.Insumo();
        #endregion

        public frmPlantacao()
        {
            InitializeComponent();
        }

        private void btnFrmCadastrarPlantacao_Click(object sender, EventArgs e)
        {
            frmAddPlantacao frmAddPlantacao = new frmAddPlantacao();
            frmAddPlantacao.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarPlantacao_Click(object sender, EventArgs e)
        {
            dgvPlantacao.DataSource = plantacaoDAL.ConsultarTodos();
        }

        private void btnAlterarPlantacao_Click(object sender, EventArgs e)
        {
            if (dgvPlantacao.RowCount > 0)
            {

                frmAddPlantacao addPlantacao = new frmAddPlantacao();
                addPlantacao.codplantacao = Convert.ToInt32(dgvPlantacao[0, dgvPlantacao.CurrentRow.Index].Value);
                addPlantacao.ShowDialog();
                dgvPlantacao.DataSource = plantacaoDAL.ConsultarTodos();


            }
        }

        private void btnExcluirPlantacao_Click(object sender, EventArgs e)
        {
            if (dgvPlantacao.RowCount > 0)
            {


                if (MessageBox.Show("Deseja realmente excluir a plantação?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    plantacao.CodPlantacao = Convert.ToInt32(dgvPlantacao[0, dgvPlantacao.CurrentRow.Index].Value);

                    //chamando metodo de excluir

                    plantacaoDAL.Excluir(plantacao);

                    //atualizando a tabela (consulta)
                    dgvPlantacao.DataSource = plantacaoDAL.ConsultarTodos();
                }
            }
        }

        private void txtPesquisarNomeInsumo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrarNomeInsumo_Click(object sender, EventArgs e)
        {
            insumo.NomeInsumo = txtPesquisarNomeInsumo.Text;
            dgvPlantacao.DataSource = insumoDAL.FiltrarPorNome(insumo);
        }

        private void lblPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
