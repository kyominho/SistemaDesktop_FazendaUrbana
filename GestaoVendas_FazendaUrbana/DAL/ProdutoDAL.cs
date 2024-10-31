using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GestaoVendas_FazendaUrbana.BLL;

namespace GestaoVendas_FazendaUrbana.DAL
{
    public class ProdutoDAL
    {
        //Classe de conexao com o banco de dados
        Conexao con = new Conexao();

        public void CadastrarProduto(BLL.Produto produto)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spCadastrarProduto";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@PrecoProduto", produto.PrecoProduto);
            cmd.Parameters.AddWithValue("@EstoqueProduto", produto.EstoqueProduto);
            cmd.Parameters.AddWithValue("@DataValidadeProduto", produto.DataValidadeProduto);

            cmd.Connection = con.Conectar(); //abrindo conexao
            cmd.ExecuteNonQuery(); //executar comando
            con.Desconectar(); //fechando conexao

        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codProduto AS 'Código', nomeProduto AS 'Nome', estoqueProduto AS 'Estoque', dataValidadeProduto AS 'Data de Validade', precoProduto AS 'Preço' FROM Produto", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;


        }

        public DataTable FiltrarPorNome(BLL.Produto produto)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codProduto AS 'Código', nomeProduto AS 'Nome', estoqueProduto AS 'Estoque', dataValidadeProduto AS 'Data de Validade', precoProduto AS 'Preço' FROM Produto WHERE nomeProduto LIKE @NomeProduto", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NomeProduto", "%" + produto.NomeProduto + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Produto produto)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spExcluirProduto";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodProduto", produto.CodProduto);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Alterar(BLL.Produto produto)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAlterarProduto";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
            cmd.Parameters.AddWithValue("@PrecoProduto", produto.PrecoProduto);
            cmd.Parameters.AddWithValue("@EstoqueProduto", produto.EstoqueProduto);
            cmd.Parameters.AddWithValue("@DataValidadeProduto", produto.DataValidadeProduto);
            cmd.Parameters.AddWithValue("@CodProduto", produto.CodProduto);


            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public BLL.Produto Retornar(BLL.Produto produto)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Produto WHERE codProduto = @CodProduto";

            cmd.Parameters.AddWithValue("@CodProduto", produto.CodProduto);

            cmd.Connection = con.Conectar();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                produto.CodProduto = Convert.ToInt32(dr["codProduto"]);
                produto.NomeProduto = dr["nomeProduto"].ToString();
                produto.PrecoProduto = Convert.ToDouble(dr["precoProduto"]);
                produto.EstoqueProduto= Convert.ToInt32(dr["estoqueProduto"]);
                produto.DataValidadeProduto = Convert.ToDateTime(dr["dataValidadeProduto"]);
                

            }

            dr.Close();
            con.Desconectar();
            return produto;


        }







    }
}
