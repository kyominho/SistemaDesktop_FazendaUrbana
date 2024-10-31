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
    public partial class frmClienteJuridico : Form
    {
        #region Instancias
        BLL.ClienteJuridico clienteJuridico = new BLL.ClienteJuridico();
        DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
        #endregion

        #region Construtor
        public frmClienteJuridico()
        {
            InitializeComponent();
        }

        #endregion

        private void btnFrmCadastrarClienteJuridico_Click(object sender, EventArgs e)
        {
            frmAddClienteJuridico frmAddClienteJuridico = new frmAddClienteJuridico();
            frmAddClienteJuridico.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarClienteJuridico_Click(object sender, EventArgs e)
        {
            dgvClienteJuridico.DataSource = clienteDAL.ConsultarTodosClientesJ();
        }

        private void btnAlterarClienteJuridico_Click(object sender, EventArgs e)
        {
            if (dgvClienteJuridico.RowCount > 0)
            {

                frmAddClienteJuridico addClienteJuridico = new frmAddClienteJuridico();
                addClienteJuridico.codclientejuridico = Convert.ToInt32(dgvClienteJuridico[0, dgvClienteJuridico.CurrentRow.Index].Value);
                addClienteJuridico.ShowDialog();
                dgvClienteJuridico.DataSource = clienteDAL.ConsultarTodosClientesJ();


            }
        }

        private void btnExcluirClienteJuridico_Click(object sender, EventArgs e)
        {
            if (dgvClienteJuridico.RowCount > 0)
            {


                if (MessageBox.Show("Deseja realmente excluir o cliente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    clienteJuridico.CodClienteJuridico = Convert.ToInt32(dgvClienteJuridico[0, dgvClienteJuridico.CurrentRow.Index].Value);

                    //chamando metodo de excluir

                    clienteDAL.ExcluirClienteJuridico(clienteJuridico);

                    //atualizando a tabela (consulta)
                    dgvClienteJuridico.DataSource = clienteDAL.ConsultarTodosClientesJ();
                }
            }
        }


        private void btnFiltrarCNPJ_Click_1(object sender, EventArgs e)
        {
            clienteJuridico.CnpjCliente = txtPesquisarCnpj.Text;
            dgvClienteJuridico.DataSource = clienteDAL.FiltrarPorCNPJ(clienteJuridico);
        }

      
    }
}
