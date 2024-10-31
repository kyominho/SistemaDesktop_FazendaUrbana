using GestaoVendas_FazendaUrbana.BLL;
using GestaoVendas_FazendaUrbana.DAL;
using GestaoVendas_FazendaUrbana.UI.ModuloCliente;
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
    public partial class frmClienteFisico : Form
    {
        #region Instancias
        BLL.ClienteFisico clienteFisico = new BLL.ClienteFisico();
        DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
        #endregion

        public frmClienteFisico()
        {
            InitializeComponent();
        }


        private void btnFrmCadastrarClienteFisico_Click_1(object sender, EventArgs e)
        {
            frmAddClienteFisico frmAddClienteFisico = new frmAddClienteFisico();
            frmAddClienteFisico.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarClienteFisico_Click(object sender, EventArgs e)
        {
            dgvClienteFisico.DataSource = clienteDAL.ConsultarTodosClientesF();
        }

        private void btnExcluirClienteFisico_Click(object sender, EventArgs e)
        {
            if (dgvClienteFisico.RowCount > 0)
            {


                if (MessageBox.Show("Deseja realmente excluir o cliente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    clienteFisico.CodClienteFisico = Convert.ToInt32(dgvClienteFisico[0, dgvClienteFisico.CurrentRow.Index].Value);

                    //chamando metodo de excluir

                    clienteDAL.ExcluirClienteFisico(clienteFisico);

                    //atualizando a tabela (consulta)
                    dgvClienteFisico.DataSource = clienteDAL.ConsultarTodosClientesF();
                }
            }
        }

        private void btnAlterarClienteFisico_Click(object sender, EventArgs e)
        {
            if (dgvClienteFisico.RowCount > 0)
            {

                frmAddClienteFisico addClienteFisico = new frmAddClienteFisico();
                addClienteFisico.codclientefisico = Convert.ToInt32(dgvClienteFisico[0, dgvClienteFisico.CurrentRow.Index].Value);
                addClienteFisico.ShowDialog();
                dgvClienteFisico.DataSource = clienteDAL.ConsultarTodosClientesF();


            }
        }

        private void btnFiltrarCpfClienteFisico_Click(object sender, EventArgs e)
        {
            clienteFisico.CpfCliente = txtPesquisarCpf.Text;
            dgvClienteFisico.DataSource = clienteDAL.FiltrarPorCPF(clienteFisico);
        }
    }
}
