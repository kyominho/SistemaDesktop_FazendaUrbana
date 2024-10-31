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
    public partial class frmProduto : Form
    {

        #region Instancias 
        DAL.ProdutoDAL produtoDAL = new DAL.ProdutoDAL();
        BLL.Produto produto = new BLL.Produto();
        #endregion
        public frmProduto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarProduto_Click(object sender, EventArgs e)
        {
            dgvProduto.DataSource = produtoDAL.ConsultarTodos();
        }

        private void btnFrmCadastrarProduto_Click(object sender, EventArgs e)
        {
            frmAddProduto frmaddProduto = new frmAddProduto(); 
            frmaddProduto.ShowDialog();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dgvProduto.RowCount > 0)
            {


                if (MessageBox.Show("Deseja realmente excluir o produto?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    produto.CodProduto = Convert.ToInt32(dgvProduto[0, dgvProduto.CurrentRow.Index].Value);

                    //chamando metodo de excluir

                    produtoDAL.Excluir(produto);

                    //atualizando a tabela (consulta)
                    dgvProduto.DataSource = produtoDAL.ConsultarTodos();
                }
            }
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {

            if (dgvProduto.RowCount > 0)
            {

                frmAddProduto addProduto = new frmAddProduto();
                addProduto.codproduto = Convert.ToInt32(dgvProduto[0, dgvProduto.CurrentRow.Index].Value);
                addProduto.ShowDialog();
                dgvProduto.DataSource = produtoDAL.ConsultarTodos();


            }
        }

        private void btnFiltrarNomeProduto_Click(object sender, EventArgs e)
        {
            produto.NomeProduto = txtPesquisarProduto.Text;
            dgvProduto.DataSource = produtoDAL.FiltrarPorNome(produto);
        }
    }
}
