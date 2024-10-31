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
    public partial class frmInsumo : Form
    {

        #region Instancias
        DAL.InsumoDAL insumoDAL = new DAL.InsumoDAL();
        BLL.Insumo insumo = new BLL.Insumo();
        #endregion
        public frmInsumo()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFrmCadastrarInsumo_Click(object sender, EventArgs e)
        {
            frmAddInsumo frmAddInsumo = new frmAddInsumo();
            frmAddInsumo.ShowDialog();
        }

        private void btnConsultarInsumo_Click(object sender, EventArgs e)
        {
            dgvInsumo.DataSource = insumoDAL.ConsultarTodos();
        }

        private void btnExcluirInsumo_Click(object sender, EventArgs e)
        {
            if (dgvInsumo.RowCount > 0)
            {


                if (MessageBox.Show("Deseja realmente excluir o insumo?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    insumo.CodInsumo = Convert.ToInt32(dgvInsumo[0, dgvInsumo.CurrentRow.Index].Value);

                    //chamando metodo de excluir

                    insumoDAL.Excluir(insumo);

                    //atualizando a tabela (consulta)
                    dgvInsumo.DataSource = insumoDAL.ConsultarTodos();
                }
            }
        }

        private void btnAlterarInsumo_Click(object sender, EventArgs e)
        {
            if (dgvInsumo.RowCount > 0)
            {

                frmAddInsumo addInsumo = new frmAddInsumo();
                addInsumo.codinsumo = Convert.ToInt32(dgvInsumo[0, dgvInsumo.CurrentRow.Index].Value);
                addInsumo.ShowDialog();
                dgvInsumo.DataSource = insumoDAL.ConsultarTodos();


            }
        }

        private void btnFiltrarNomeInsumo_Click(object sender, EventArgs e)
        {
            insumo.NomeInsumo = txtPesquisarInsumo.Text;
            dgvInsumo.DataSource = insumoDAL.FiltrarPorNome(insumo);
        }
    }
}
