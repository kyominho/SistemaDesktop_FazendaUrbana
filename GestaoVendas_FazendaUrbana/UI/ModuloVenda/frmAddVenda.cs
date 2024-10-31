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
    public partial class frmAddVenda : Form
    {
        #region Instancias 
        DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
        DAL.ProdutoDAL produtoDAL = new DAL.ProdutoDAL();
        DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();

        BLL.Produto produto = new BLL.Produto();

        BLL.ItensVenda itensVenda = new BLL.ItensVenda();
        DAL.itensVendaDAL itensVendaDAL = new itensVendaDAL();

        DAL.VendaDAL vendaDAL = new DAL.VendaDAL(); 
        BLL.Venda venda = new BLL.Venda();
        #endregion

        public frmAddVenda()
        {
            InitializeComponent();
        }

        private void frmAddVenda_Load(object sender, EventArgs e)
        {
            cmbClientes.DataSource = clienteDAL.ConsultarTodos();
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.ValueMember = "Código";

            cmbProduto.DataSource = produtoDAL.ConsultarTodos();
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "Código";

            cmbUsuarios.DataSource = usuarioDAL.ConsultarTodos();
            cmbUsuarios.DisplayMember = "Nome";
            cmbUsuarios.ValueMember = "Código";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt16(cmbProduto.SelectedValue) <= 0 && txtQuantidade.Value <= 0) return;
            produto.CodProduto = Convert.ToInt16(cmbProduto.SelectedValue);
            produto = produtoDAL.Retornar(produto);

            int quantidade = Convert.ToInt32(txtQuantidade.Value);
            double subtotal = produto.PrecoProduto * quantidade;
            if (produto.EstoqueProduto < quantidade)
            {
                MessageBox.Show("Estoque insuficiente", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                if (Convert.ToInt32(dgvItens[0, i].Value) == Convert.ToInt32(cmbProduto.SelectedValue))
                {
                    quantidade += Convert.ToInt32(dgvItens[2, i].Value);
                    if (produto.EstoqueProduto < quantidade)
                    {
                        MessageBox.Show("Estoque insuficiente", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    subtotal = produto.PrecoProduto * quantidade;
                    dgvItens[2, i].Value = quantidade;
                    dgvItens[4, i].Value = subtotal;
                    calcularTotal();
                    return;
                }
            }

            dgvItens.Rows.Add(cmbProduto.SelectedValue.ToString(), cmbProduto.Text, txtQuantidade.Text, produto.PrecoProduto.ToString("n"), subtotal.ToString("n"));
            calcularTotal();
        }

        public void calcularTotal()
        {
            double total = 0;
            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                total += Convert.ToDouble(dgvItens[4, i].Value);
            }
            lblTotal.Text = "Total: R$ " + total.ToString("n");
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvItens.RowCount <= 0 || Convert.ToInt16(cmbClientes.SelectedValue) <= 0 || cmbForma.Text.Trim() == "")
            {
                MessageBox.Show("Preencha corretamente as informações", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            venda.DataHorarioVenda = DateTime.Now;
            venda.CodClienteV = Convert.ToInt32(cmbClientes.SelectedValue);
            venda.FormaPagamentoVenda = cmbForma.Text;
            venda.CodUsuarioV = frmLogin.codusuario;
            itensVenda.CodVendaIV = vendaDAL.CadastrarVenda(venda);

            for (int i = 0; i < dgvItens.RowCount; i++)
            {
                itensVenda.CodProdutoIV = Convert.ToInt32(dgvItens[0, i].Value);
                itensVenda.QuantidadeItensVenda = Convert.ToInt32(dgvItens[2, i].Value);
                itensVenda.ValorTotalItensVenda = Convert.ToDouble(dgvItens[3, i].Value);
                itensVendaDAL.CadastrarItens(itensVenda);
            }
            MessageBox.Show("Dados gravados com sucesso!", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dgvItens.Rows.Clear(); //limpar grid
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.RowCount > 0)
            {
                dgvItens.Rows.Remove(dgvItens.CurrentRow);
            }
            calcularTotal();
        }
    }
}
