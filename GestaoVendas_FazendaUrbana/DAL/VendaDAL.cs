using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GestaoVendas_FazendaUrbana.BLL;

namespace GestaoVendas_FazendaUrbana.DAL
{
    public class VendaDAL
    {
        Conexao con = new Conexao();

        public int CadastrarVenda(BLL.Venda venda)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Venda (dataHorarioVenda, formaPagamentoVenda, codUsuarioV, codClienteV)
            VALUES (@DataHorarioVenda, @FormaPagamentoVenda, @CodUsuarioV, @CodClienteV);SELECT SCOPE_IDENTITY();";

            cmd.Parameters.AddWithValue("@DataHorarioVenda", venda.DataHorarioVenda);
            cmd.Parameters.AddWithValue("@FormaPagamentoVenda", venda.FormaPagamentoVenda);
            cmd.Parameters.AddWithValue("@CodUsuarioV", venda.CodUsuarioV);
            cmd.Parameters.AddWithValue("@CodClienteV", venda.CodClienteV);
            cmd.Connection = con.Conectar();//abrir a conexão
            int id = Convert.ToInt16(cmd.ExecuteScalar());
            con.Desconectar();
            return id;



        }

        public void Excluir(BLL.Venda venda)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spExcluirVenda";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodVenda", venda.CodVenda);
            cmd.Connection = con.Conectar();//abrir a conexão
            cmd.ExecuteNonQuery();//executar o comando
            con.Desconectar();
        }


        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codVenda AS Código, dataHorarioVenda AS Data, formaPagamentoVenda AS [Forma de Pagamento], Cliente.nomeCliente AS Cliente, Usuario.nomeUsuario AS Funcionário
            FROM Venda JOIN Cliente ON Cliente.codCliente = Venda.codClienteV
            JOIN Usuario ON Usuario.codUsuario = Venda.codUsuarioV", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable QuantidadeVendas()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT nomeCliente AS Cliente, COUNT(Cliente.codCliente) AS [Quantidade de Compras] 
            FROM Venda JOIN Cliente ON Cliente.codCliente = Venda.codClienteV
            GROUP BY nomeCliente", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable FiltrarPorNome(BLL.Cliente cliente)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codVenda AS Código, dataHorarioVenda AS Data, formaPagamentoVenda AS [Forma de Pagamento], Cliente.nomeCliente AS Cliente, Usuario.nomeUsuario AS Funcionário
            FROM Venda JOIN Cliente ON Cliente.codCliente = Venda.codClienteV
            JOIN Usuario ON Usuario.codUsuario = Venda.codUsuarioV WHERE Cliente.nomeCliente LIKE @NomeCliente", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NomeCliente", "%" + cliente.NomeCliente + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

    }
}
