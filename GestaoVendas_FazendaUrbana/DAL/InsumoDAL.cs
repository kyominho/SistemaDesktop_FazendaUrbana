using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas_FazendaUrbana.DAL
{
    public class InsumoDAL
    {
        //Classe de conexao com o banco de dados
        Conexao con = new Conexao();

        public void CadastrarInsumo(BLL.Insumo insumo)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spCadastrarInsumo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeInsumo", insumo.NomeInsumo);
            cmd.Parameters.AddWithValue("@EstoqueInsumo", insumo.EstoqueInsumo);
            cmd.Parameters.AddWithValue("@DataValidadeInsumo", insumo.DataValidadeInsumo);
            cmd.Parameters.AddWithValue("@PrecoInsumo", insumo.PrecoInsumo);
           
            cmd.Connection = con.Conectar(); //abrindo conexao
            cmd.ExecuteNonQuery(); //executar comando
            con.Desconectar(); //fechando conexao

        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codInsumo AS 'Código', nomeInsumo AS 'Nome', estoqueInsumo AS 'Estoque', dataValidadeInsumo AS 'Data de Validade', precoInsumo AS 'Preço' FROM Insumo", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;


        }

        public DataTable FiltrarPorNome(BLL.Insumo insumo)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codInsumo AS 'Código', nomeInsumo AS 'Nome', estoqueInsumo AS 'Estoque', dataValidadeInsumo AS 'Data de Validade', precoInsumo AS 'Preço' FROM Insumo WHERE nomeInsumo LIKE @NomeInsumo", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NomeInsumo",  "%" + insumo.NomeInsumo + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Insumo insumo)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spExcluirInsumo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodInsumo", insumo.CodInsumo);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Alterar(BLL.Insumo insumo)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAlterarInsumo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeInsumo", insumo.NomeInsumo);
            cmd.Parameters.AddWithValue("@EstoqueInsumo", insumo.EstoqueInsumo);
            cmd.Parameters.AddWithValue("@DataValidadeInsumo", insumo.DataValidadeInsumo);
            cmd.Parameters.AddWithValue("@PrecoInsumo", insumo.PrecoInsumo);
            cmd.Parameters.AddWithValue("@CodInsumo", insumo.CodInsumo);


            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public BLL.Insumo Retornar(BLL.Insumo insumo)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Insumo WHERE codInsumo = @CodInsumo";

            cmd.Parameters.AddWithValue("@CodInsumo", insumo.CodInsumo);

            cmd.Connection = con.Conectar();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                insumo.CodInsumo = Convert.ToInt32(dr["codInsumo"]);
                insumo.NomeInsumo = dr["nomeInsumo"].ToString();
                insumo.EstoqueInsumo = Convert.ToInt32(dr["estoqueInsumo"]);
                insumo.DataValidadeInsumo= Convert.ToDateTime(dr["dataValidadeInsumo"]);
                insumo.PrecoInsumo = Convert.ToDouble(dr["precoInsumo"]);

            }

            dr.Close();
            con.Desconectar();
            return insumo;


        }







    }
}
