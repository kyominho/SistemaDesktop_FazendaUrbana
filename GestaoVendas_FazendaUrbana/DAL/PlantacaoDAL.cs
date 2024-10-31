using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas_FazendaUrbana.DAL
{
    public class PlantacaoDAL
    {
        //Classe de conexao com o banco de dados
        Conexao con = new Conexao();

        public void CadastrarPlantacao(BLL.Plantacao plantacao)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spCadastrarPlantacao";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DataPlantacao", plantacao.DataPlantacao);
            cmd.Parameters.AddWithValue("@HorarioPlantacao", plantacao.HorarioPlantacao);
            cmd.Parameters.AddWithValue("@QuantidadePlantacao", plantacao.QuantidadePlantacao);
            cmd.Parameters.AddWithValue("@CodInsumoP", plantacao.CodInsumoP);

            cmd.Connection = con.Conectar(); //abrindo conexao
            cmd.ExecuteNonQuery(); //executar comando
            con.Desconectar(); //fechando conexao

        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codPlantacao AS 'Código', dataPlantacao AS 'Data', horarioPlantacao AS 'Horário', quantidadePlantacao AS 'Quantidade Plantada', nomeInsumo AS 'Nome do Insumo' FROM Plantacao JOIN Insumo ON Plantacao.codInsumoP = Insumo.codInsumo", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;


        }

       


        public void Excluir(BLL.Plantacao plantacao)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spExcluirPlantacao";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodPlantacao", plantacao.CodPlantacao);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Alterar(BLL.Plantacao plantacao)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAlterarPlantacao";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DataPlantacao", plantacao.DataPlantacao);
            cmd.Parameters.AddWithValue("@HorarioPlantacao", plantacao.HorarioPlantacao);
            cmd.Parameters.AddWithValue("@QuantidadePlantacao", plantacao.QuantidadePlantacao);
            cmd.Parameters.AddWithValue("@CodInsumoP", plantacao.CodInsumoP);
            cmd.Parameters.AddWithValue("@CodPlantacao", plantacao.CodPlantacao);


            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public BLL.Plantacao Retornar(BLL.Plantacao plantacao)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Plantacao WHERE codPlantacao = @CodPlantacao";

            cmd.Parameters.AddWithValue("@CodPlantacao", plantacao.CodPlantacao);

            cmd.Connection = con.Conectar();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                plantacao.CodPlantacao = Convert.ToInt32(dr["codPlantacao"]);
                plantacao.DataPlantacao = Convert.ToDateTime(dr["dataPlantacao"]);
                plantacao.HorarioPlantacao = Convert.ToDateTime(dr["horarioPlantacao"]);
                plantacao.QuantidadePlantacao = Convert.ToInt32(dr["quantidadePlantacao"]);
                plantacao.CodInsumoP = Convert.ToInt32(dr["codInsumoP"]);

            }

            dr.Close();
            con.Desconectar();
            return plantacao;


        }

        public DataTable FiltrarPorNome(BLL.Insumo insumo)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codPlantacao AS 'Código', dataPlantacao AS 'Data', horarioPlantacao AS 'Horário', quantidadePlantacao AS 'Quantidade Plantada', nomeInsumo AS 'Nome do Insumo' FROM Plantacao JOIN Insumo ON Plantacao.codInsumoP = Insumo.codInsumo
             WHERE Insumo.nomeInsumo LIKE @NomeInsumo", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NomeInsumo", "%" + insumo.NomeInsumo + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }


    }
}
