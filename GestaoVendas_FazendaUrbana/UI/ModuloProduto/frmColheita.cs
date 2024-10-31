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
    public partial class frmColheita : Form
    {
         #region Instancias
         DAL.ColheitaDAL colheitaDAL = new DAL.ColheitaDAL();
         BLL.Colheita colheita = new BLL.Colheita();
         DAL.ProdutoDAL produtoDAL = new DAL.ProdutoDAL();
         BLL.Produto produto = new BLL.Produto();
        #endregion


        public frmColheita()
        {
            InitializeComponent();
        }

        private void btnFrmCadastrarColheita_Click(object sender, EventArgs e)
        {
            frmAddColheita frmAddColheita = new frmAddColheita();
            frmAddColheita.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarColheita_Click(object sender, EventArgs e)
        {
            dgvColheita.DataSource = colheitaDAL.ConsultarTodos();
        }

        private void btnExcluirColheita_Click(object sender, EventArgs e)
        {
            if (dgvColheita.RowCount > 0)
            {


                if (MessageBox.Show("Deseja realmente excluir a colheita?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    colheita.CodColheita = Convert.ToInt32(dgvColheita[0, dgvColheita.CurrentRow.Index].Value);

                    //chamando metodo de excluir

                    colheitaDAL.Excluir(colheita);

                    //atualizando a tabela (consulta)
                    dgvColheita.DataSource = colheitaDAL.ConsultarTodos();
                }
            }
        }

        private void btnAlterarColheita_Click(object sender, EventArgs e)
        {
            if (dgvColheita.RowCount > 0)
            {

                frmAddColheita addColheita = new frmAddColheita();
                addColheita.codcolheita = Convert.ToInt32(dgvColheita[0, dgvColheita.CurrentRow.Index].Value);
                addColheita.ShowDialog();
                dgvColheita.DataSource = colheitaDAL.ConsultarTodos();


            }
        }

        private void btnFiltrarNomeProduto_Click(object sender, EventArgs e)
        {
            produto.NomeProduto= txtPesquisarNomeProduto.Text;
            dgvColheita.DataSource = produtoDAL.FiltrarPorNome(produto);
        }
    }
}
