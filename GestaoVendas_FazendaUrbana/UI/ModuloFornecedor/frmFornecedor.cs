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
    public partial class frmFornecedor : Form
    {

        BLL.Fornecedor fornecedor = new BLL.Fornecedor();   
        DAL.FornecedorDAL fornecedorDAL = new DAL.FornecedorDAL();
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void btnFrmAddFornecedor_Click(object sender, EventArgs e)
        {
            frmAddFornecedor frmAddFornecedor = new frmAddFornecedor();
            frmAddFornecedor.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarFornecedor_Click(object sender, EventArgs e)
        {
            //dgvConsulta.DataSource = cliDAL.ConsultarTodos();
            dgvFornecedor.DataSource = fornecedorDAL.ConsultarTodos();
        }

        private void btnAlterarFornecedor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.RowCount > 0)
            {

                frmAddFornecedor addFornecedor = new frmAddFornecedor();
                addFornecedor.codfornecedor = Convert.ToInt32(dgvFornecedor[0, dgvFornecedor.CurrentRow.Index].Value);
                addFornecedor.ShowDialog();
                dgvFornecedor.DataSource = fornecedorDAL.ConsultarTodos();


            }
        }

        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.RowCount > 0)
            {


                if (MessageBox.Show("Deseja realmente excluir o fornecedor?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    fornecedor.CodFornecedor = Convert.ToInt32(dgvFornecedor[0, dgvFornecedor.CurrentRow.Index].Value);

                    //chamando metodo de excluir

                    fornecedorDAL.Excluir(fornecedor);

                    //atualizando a tabela (consulta)
                    dgvFornecedor.DataSource = fornecedorDAL.ConsultarTodos();
                }
            }
        }

        private void btnFiltrarNomeFornecedor_Click(object sender, EventArgs e)
        {
            fornecedor.NomeFornecedor = txtPesquisarFornecedor.Text;
            dgvFornecedor.DataSource = fornecedorDAL.FiltrarPorNome(fornecedor);
        }

     

        private void lblPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
