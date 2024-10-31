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
    public partial class frmCliente : Form
    {
        #region Instancias 
        BLL.Cliente cliente = new BLL.Cliente();
        DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
        #endregion
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnFrmCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmAddCliente cliente = new frmAddCliente();
            cliente.ShowDialog();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (dgvConsultaCliente.RowCount > 0)
            {


                if (MessageBox.Show("Deseja realmente excluir o cliente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cliente.CodCliente = Convert.ToInt32(dgvConsultaCliente[0, dgvConsultaCliente.CurrentRow.Index].Value);

                    //chamando metodo de excluir

                    clienteDAL.Excluir(cliente);

                    //atualizando a tabela (consulta)
                    dgvConsultaCliente.DataSource = clienteDAL.ConsultarTodos();
                }
            }
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            dgvConsultaCliente.DataSource = clienteDAL.ConsultarTodos();
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (dgvConsultaCliente.RowCount > 0)
            {

                frmAddCliente addCliente = new frmAddCliente();
                addCliente.codcliente = Convert.ToInt32(dgvConsultaCliente[0, dgvConsultaCliente.CurrentRow.Index].Value);
                addCliente.ShowDialog();
                dgvConsultaCliente.DataSource = clienteDAL.ConsultarTodos();


            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrarNomeCliente_Click(object sender, EventArgs e)
        {
            cliente.NomeCliente = txtPesquisarCliente.Text;
            dgvConsultaCliente.DataSource = clienteDAL.FiltrarPorNome(cliente);
        }
    }
}
