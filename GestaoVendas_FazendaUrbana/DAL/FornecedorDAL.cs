using GestaoVendas_FazendaUrbana.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestaoVendas_FazendaUrbana.DAL
{
    public class FornecedorDAL
    {
        Conexao con = new Conexao();

        public void CadastrarFornecedor(BLL.Fornecedor fornecedor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spCadastrarFornecedor";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeFornecedor", fornecedor.NomeFornecedor);
            cmd.Parameters.AddWithValue("@EmailFornecedor", fornecedor.EmailFornecedor);
            cmd.Parameters.AddWithValue("@UfFornecedor", fornecedor.UfFornecedor);
            cmd.Parameters.AddWithValue("@CidadeFornecedor", fornecedor.CidadeFornecedor);
            cmd.Parameters.AddWithValue("@TelefoneFornecedor", fornecedor.TelefoneFornecedor);
            cmd.Parameters.AddWithValue("@CepFornecedor", fornecedor.CepFornecedor);
            cmd.Parameters.AddWithValue("@LogradouroFornecedor", fornecedor.LogradouroFornecedor);
            cmd.Parameters.AddWithValue("@NumeroEnderecoFornecedor", fornecedor.NumeroEnderecoFornecedor);
            cmd.Parameters.AddWithValue("@CnpjFornecedor", fornecedor.CnpjFornecedor);
            cmd.Parameters.AddWithValue("@RazaoSocialFornecedor", fornecedor.RazaoSocialFornecedor);

            cmd.Connection = con.Conectar(); //abrindo conexao
            cmd.ExecuteNonQuery(); //executar comando
            con.Desconectar(); //fechando conexao
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codFornecedor AS 'Código', nomeFornecedor AS 'Nome', emailFornecedor AS [E-mail], ufFornecedor 
            AS 'UF', cidadeFornecedor AS 'Cidade', telefoneFornecedor AS 'Telefone', cepFornecedor AS 'CEP', logradouroFornecedor AS 'Logradouro', 
            numeroEnderecoFornecedor AS 'Número Logradouro', cnpjFornecedor AS 'CNPJ', razaoSocialFornecedor AS 'Razão Social' FROM Fornecedor", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;

        }

        public DataTable FiltrarPorNome(BLL.Fornecedor fornecedor)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codFornecedor AS 'Código', nomeFornecedor AS 'Nome', emailFornecedor AS [E-mail], ufFornecedor 
            AS 'UF', cidadeFornecedor AS 'Cidade', telefoneFornecedor AS 'Telefone', cepFornecedor AS 'CEP', logradouroFornecedor AS 'Logradouro', 
            numeroEnderecoFornecedor AS 'Número Logradouro', cnpjFornecedor AS 'CNPJ', razaoSocialFornecedor AS 'Razão Social' FROM Fornecedor WHERE nomeFornecedor LIKE @NomeFornecedor", con.Conectar());

            da.SelectCommand.Parameters.AddWithValue("@NomeFornecedor", fornecedor.NomeFornecedor + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Fornecedor fornecedor)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spExcluirFornecedor";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodFornecedor", fornecedor.CodFornecedor);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Alterar(BLL.Fornecedor fornecedor)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAlterarFornecedor";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeFornecedor", fornecedor.NomeFornecedor);
            cmd.Parameters.AddWithValue("@EmailFornecedor", fornecedor.EmailFornecedor);
            cmd.Parameters.AddWithValue("@UfFornecedor", fornecedor.UfFornecedor);
            cmd.Parameters.AddWithValue("@CidadeFornecedor", fornecedor.CidadeFornecedor);
            cmd.Parameters.AddWithValue("@TelefoneFornecedor", fornecedor.TelefoneFornecedor);
            cmd.Parameters.AddWithValue("@CepFornecedor", fornecedor.CepFornecedor);
            cmd.Parameters.AddWithValue("@LogradouroFornecedor", fornecedor.LogradouroFornecedor);
            cmd.Parameters.AddWithValue("@NumeroEnderecoFornecedor", fornecedor.NumeroEnderecoFornecedor);
            cmd.Parameters.AddWithValue("@CnpjFornecedor", fornecedor.CnpjFornecedor);
            cmd.Parameters.AddWithValue("@RazaoSocialFornecedor", fornecedor.RazaoSocialFornecedor);
            cmd.Parameters.AddWithValue("@CodFornecedor", fornecedor.CodFornecedor);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();




        }

         public BLL.Fornecedor Retornar(BLL.Fornecedor fornecedor)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Fornecedor WHERE codFornecedor = @CodFornecedor";

            cmd.Parameters.AddWithValue("@CodFornecedor",fornecedor.CodFornecedor);

            cmd.Connection = con.Conectar();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                fornecedor.CodFornecedor = Convert.ToInt32(dr["codFornecedor"]);
                fornecedor.NomeFornecedor = dr["nomeFornecedor"].ToString();
                fornecedor.EmailFornecedor = dr["emailFornecedor"].ToString();
                fornecedor.UfFornecedor = dr["ufFornecedor"].ToString();
                fornecedor.CidadeFornecedor = dr["cidadeFornecedor"].ToString();
                fornecedor.TelefoneFornecedor = dr["telefoneFornecedor"].ToString();
                fornecedor.CepFornecedor = dr["cepFornecedor"].ToString();
                fornecedor.LogradouroFornecedor = dr["logradouroFornecedor"].ToString();
                fornecedor.NumeroEnderecoFornecedor= Convert.ToInt32(dr["numeroEnderecoFornecedor"]);
                fornecedor.CnpjFornecedor = dr["cnpjFornecedor"].ToString();
                fornecedor.RazaoSocialFornecedor = dr["razaoSocialFornecedor"].ToString();
              
            }

            dr.Close();
            con.Desconectar();
            return fornecedor;


        }
    }





}

