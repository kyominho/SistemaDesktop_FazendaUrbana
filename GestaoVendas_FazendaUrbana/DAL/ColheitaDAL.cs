using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas_FazendaUrbana.DAL
{
    public class ColheitaDAL
    {
        //Classe de conexao com o banco de dados
        Conexao con = new Conexao();

        public void CadastrarColheita(BLL.Colheita colheita)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spCadastrarColheita";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DataColheita", colheita.DataColheita);
            cmd.Parameters.AddWithValue("@HorarioColheita", colheita.HorarioColheita);
            cmd.Parameters.AddWithValue("@QuantidadeColheita", colheita.QuantidadeColheita);
            cmd.Parameters.AddWithValue("@CodProdutoC", colheita.CodProdutoC);

            cmd.Connection = con.Conectar(); //abrindo conexao
            cmd.ExecuteNonQuery(); //executar comando
            con.Desconectar(); //fechando conexao

        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codColheita AS 'Código', dataColheita AS 'Data', horarioColheita AS 'Horário', quantidadeColheita AS 'Quantidade Colhida', nomeProduto AS 'Nome do Produto' FROM Colheita JOIN Produto ON Colheita.codProdutoC = Produto.codProduto", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;


        }




        public void Excluir(BLL.Colheita colheita)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spExcluirColheita";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodColheita", colheita.CodColheita);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Alterar(BLL.Colheita colheita)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAlterarColheita";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@DataColheita", colheita.DataColheita);
            cmd.Parameters.AddWithValue("@HorarioColheita", colheita.HorarioColheita);
            cmd.Parameters.AddWithValue("@QuantidadeColheita", colheita.QuantidadeColheita);
            cmd.Parameters.AddWithValue("@CodProdutoC", colheita.CodProdutoC);
            cmd.Parameters.AddWithValue("@CodColheita", colheita.CodColheita);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public BLL.Colheita Retornar(BLL.Colheita colheita)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Colheita WHERE codColheita = @CodColheita";

            cmd.Parameters.AddWithValue("@CodColheita", colheita.CodColheita);

            cmd.Connection = con.Conectar();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                colheita.CodColheita = Convert.ToInt32(dr["codColheita"]);
                colheita.DataColheita = Convert.ToDateTime(dr["dataColheita"]);
                colheita.HorarioColheita = Convert.ToDateTime(dr["horarioColheita"]);
                colheita.QuantidadeColheita = Convert.ToInt32(dr["quantidadePColheita"]);
                colheita.CodProdutoC = Convert.ToInt32(dr["codProdutoC"]);

            }

            dr.Close();
            con.Desconectar();
            return colheita;


        }

        public DataTable FiltrarPorNome(BLL.Produto produto)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codColheita AS 'Código', dataColheita AS 'Data', horarioColheita AS 'Horário', quantidadeColheita AS 'Quantidade Colhida', nomeProduto AS 'Nome do Produto' FROM Colheita JOIN Produto ON Colheita.codProdutoC = Produto.codProduto
            WHERE Produto.NomeProduto LIKE @NomeProduto", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NomeProduto", "%" + produto.NomeProduto + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }


    }
}
