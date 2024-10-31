using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestaoVendas_FazendaUrbana.DAL
{
    public class itensVendaDAL
    {
        Conexao con = new Conexao();

        public void CadastrarItens(BLL.ItensVenda itensVenda)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spCadastrarItensVenda";
            cmd.CommandType = CommandType.StoredProcedure;

           
            cmd.Parameters.AddWithValue("@QuantidadeItensVenda", itensVenda.QuantidadeItensVenda);
            cmd.Parameters.AddWithValue("@ValorTotalItensVenda", itensVenda.ValorTotalItensVenda);
            cmd.Parameters.AddWithValue("@CodProdutoIV", itensVenda.CodProdutoIV);
            cmd.Parameters.AddWithValue("@CodVendaIV", itensVenda.CodVendaIV);

            cmd.Connection = con.Conectar();//abrir a conexão
            cmd.ExecuteNonQuery();//executar o comando
            con.Desconectar();
        }
    }
}
