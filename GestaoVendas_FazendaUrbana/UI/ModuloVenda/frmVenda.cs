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
    public partial class frmVenda : Form
    {
        #region Instancias
        DAL.VendaDAL vendaDAL = new DAL.VendaDAL();
        BLL.Venda venda = new BLL.Venda();

        BLL. Cliente cliente = new BLL.Cliente();

        BLL.Produto produto = new BLL.Produto();
        DAL.ProdutoDAL produtoDAL = new DAL.ProdutoDAL();

        #endregion
        public frmVenda()
        {
            InitializeComponent();
        }

        private void btnFrmCadastrarVenda_Click(object sender, EventArgs e)
        {
            frmAddVenda frmaddVenda = new frmAddVenda();
            frmaddVenda.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarVenda_Click(object sender, EventArgs e)
        {
            dgvVenda.DataSource = vendaDAL.ConsultarTodos();
        }

        private void btnFiltrarNomeCliente_Click(object sender, EventArgs e)
        {
            cliente.NomeCliente = txtPesquisarCliente.Text;
            dgvVenda.DataSource = vendaDAL.FiltrarPorNome(cliente);
        }

        private void btnQuantidade_Click(object sender, EventArgs e)
        {
            dgvVenda.DataSource = vendaDAL.QuantidadeVendas();
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            if (dgvVenda.RowCount > 0 && MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                venda.CodVenda = Convert.ToInt32(dgvVenda[0, dgvVenda.CurrentRow.Index].Value);
                vendaDAL.Excluir(venda);
                dgvVenda.DataSource = vendaDAL.ConsultarTodos();
            }
        }
    }
}
