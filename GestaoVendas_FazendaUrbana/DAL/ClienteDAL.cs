using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GestaoVendas_FazendaUrbana.DAL
{
    public class ClienteDAL
    {
        Conexao con = new Conexao();

        #region Cliente
        public void CadastrarCliente(BLL.Cliente cliente)
        {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spCadastrarCliente";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente);
                cmd.Parameters.AddWithValue("@EmailCliente", cliente.EmailCliente);
                cmd.Parameters.AddWithValue("@UfCliente", cliente.UFCliente);
                cmd.Parameters.AddWithValue("@CidadeCliente", cliente.CidadeCliente);
                cmd.Parameters.AddWithValue("@TelefoneCliente", cliente.TelefoneCliente);
                cmd.Parameters.AddWithValue("@CepCliente", cliente.CepCliente);
                cmd.Parameters.AddWithValue("@LogradouroCliente", cliente.LogradouroCliente);
                cmd.Parameters.AddWithValue("@NumEnderecoCliente", cliente.NumEnderecoCliente);

                
                cmd.Connection = con.Conectar(); //abrindo conexao
                cmd.ExecuteNonQuery(); //executar comando
                con.Desconectar(); //fechando conexao

        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codCliente AS 'Código', nomeCliente AS 'Nome', emailCliente AS [E-mail], ufCliente AS 'UF', cidadeCliente AS 'Cidade', telefoneCliente AS 'Telefone', cepCliente AS 'CEP', logradouroCliente AS 'Logradouro', numeroEnderecoCliente AS 'Número Logradouro' FROM Cliente", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;

        }

        public DataTable FiltrarPorNome(BLL.Cliente cliente)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codCliente AS 'Código', nomeCliente AS 'Nome', emailCliente AS [E-mail], ufCliente AS 'UF', cidadeCliente AS 'Cidade', telefoneCliente AS 'Telefone', cepCliente AS 'CEP', logradouroCliente AS 'Logradouro', numeroEnderecoCliente AS 'Número Logradouro' FROM Cliente WHERE nomeCliente LIKE @NomeCliente", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NomeCliente", "%" + cliente.NomeCliente + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Alterar(BLL.Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAlterarCliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeCliente", cliente.NomeCliente);
            cmd.Parameters.AddWithValue("@EmailCliente", cliente.EmailCliente);
            cmd.Parameters.AddWithValue("@UfCliente", cliente.UFCliente);
            cmd.Parameters.AddWithValue("@CidadeCliente", cliente.CidadeCliente);
            cmd.Parameters.AddWithValue("@TelefoneCliente", cliente.TelefoneCliente);
            cmd.Parameters.AddWithValue("@CepCliente", cliente.CepCliente);
            cmd.Parameters.AddWithValue("@LogradouroCliente", cliente.LogradouroCliente);
            cmd.Parameters.AddWithValue("@NumEnderecoCliente", cliente.NumEnderecoCliente);
            cmd.Parameters.AddWithValue("@CodCliente", cliente.CodCliente);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public void Excluir(BLL.Cliente cliente)
        {
            

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spExcluirCliente";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodCliente", cliente.CodCliente);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();

            


        }

        public BLL.Cliente Retornar(BLL.Cliente cliente)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Cliente WHERE codCliente = @CodCliente";

            cmd.Parameters.AddWithValue("@CodCliente", cliente.CodCliente);

            cmd.Connection = con.Conectar();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                cliente.CodCliente = Convert.ToInt32(dr["codCliente"]);
                cliente.NomeCliente = dr["nomeCliente"].ToString();
                cliente.EmailCliente = dr["emailCliente"].ToString();
                cliente.UFCliente = dr["ufCliente"].ToString();
                cliente.CidadeCliente = dr["cidadeCliente"].ToString();
                cliente.TelefoneCliente = dr["telefoneCliente"].ToString();
                cliente.CepCliente = dr["cepCliente"].ToString();
                cliente.LogradouroCliente = dr["logradouroCliente"].ToString();
                cliente.NumEnderecoCliente = Convert.ToInt32(dr["numeroEnderecoCliente"]);
                

            }

            dr.Close();
            con.Desconectar();
            return cliente;


        }






        #endregion


        #region ClienteJuridico
        public void CadastrarClienteJuridico (BLL.ClienteJuridico clienteJuridico)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spCadastrarClienteJuridico";
            cmd.CommandType= CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CnpjCliente", clienteJuridico.CnpjCliente);
            cmd.Parameters.AddWithValue("@RazaoSocialCliente", clienteJuridico.RazaoSocialCliente);
            cmd.Parameters.AddWithValue("@CodClienteJ", clienteJuridico.CodClienteJ);
            
          

            cmd.Connection = con.Conectar(); //abrindo conexao
            cmd.ExecuteNonQuery(); //executar comando
            con.Desconectar(); //fechando conexao
        }

        public void ExcluirClienteJuridico(BLL.ClienteJuridico clienteJuridico)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spExcluirClienteJuridico";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodClienteJuridico", clienteJuridico.CodClienteJuridico);


            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void AlterarClienteJuridico(BLL.ClienteJuridico clienteJuridico)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAlterarClienteJuridico";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CnpjCliente", clienteJuridico.CnpjCliente);
            cmd.Parameters.AddWithValue("@RazaoSocialCliente", clienteJuridico.RazaoSocialCliente);
            cmd.Parameters.AddWithValue("@CodClienteJ", clienteJuridico.CodClienteJ);
            cmd.Parameters.AddWithValue("@CodClienteJuridico", clienteJuridico.CodClienteJuridico);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public DataTable ConsultarTodosClientesJ()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codClienteJuridico AS 'Código', cnpjCliente AS 'CNPJ', razaoSocialCliente AS 'Razão Social', nomeCliente AS 'Nome' FROM ClienteJuridico JOIN Cliente ON ClienteJuridico.codClienteJ = Cliente.codCliente", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;

        }

        public DataTable FiltrarPorCNPJ(BLL.ClienteJuridico clienteJuridico)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codClienteJuridico AS 'Código', cnpjCliente AS 'CNPJ', razaoSocialCliente AS 'Razão Social', nomeCliente AS 'Nome' FROM ClienteJuridico JOIN Cliente ON ClienteJuridico.codClienteJ = Cliente.codCliente WHERE cnpjCliente LIKE @CnpjCliente", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@CnpjCliente", "%" + clienteJuridico.CnpjCliente + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public BLL.ClienteJuridico RetornarClienteJuridico(BLL.ClienteJuridico clienteJuridico)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM ClienteJuridico WHERE codClienteJuridico = @CodClienteJuridico";

            cmd.Parameters.AddWithValue("@CodClienteJuridico", clienteJuridico.CodClienteJuridico);

            cmd.Connection = con.Conectar();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                clienteJuridico.CodClienteJuridico = Convert.ToInt32(dr["codClienteJuridico"]);
                clienteJuridico.CnpjCliente = dr["cnpjCliente"].ToString();
                clienteJuridico.RazaoSocialCliente = dr["razaoSocialCliente"].ToString();
                clienteJuridico.CodClienteJ = Convert.ToInt32(dr["codClienteJ"]);


            }

            dr.Close();
            con.Desconectar();
            return clienteJuridico;


        }



        #endregion


        #region ClienteFisico

        public void CadastrarClienteFisico(BLL.ClienteFisico clienteFisico)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spCadastrarClienteFisico";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CpfCliente", clienteFisico.CpfCliente);
            cmd.Parameters.AddWithValue("@CodClienteF", clienteFisico.CodClienteF);



            cmd.Connection = con.Conectar(); //abrindo conexao
            cmd.ExecuteNonQuery(); //executar comando
            con.Desconectar(); //fechando conexao
        }

        public void ExcluirClienteFisico(BLL.ClienteFisico clienteFisico)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spExcluirClienteFisico";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodClienteFisico", clienteFisico.CodClienteFisico);


            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void AlterarClienteFisico(BLL.ClienteFisico clienteFisico)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAlterarClienteFisico";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CpfCliente", clienteFisico.CpfCliente);
            cmd.Parameters.AddWithValue("@CodClienteF", clienteFisico.CodClienteF);
            cmd.Parameters.AddWithValue("@CodClienteFisico", clienteFisico.CodClienteFisico);
            

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public DataTable ConsultarTodosClientesF()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codClienteFisico AS 'Código', cpfCliente AS 'CPF', nomeCliente AS 'Nome' FROM ClienteFisico JOIN Cliente ON ClienteFisico.codClienteF = Cliente.codCliente", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;

        }

        public BLL.ClienteFisico RetornarClienteFisico(BLL.ClienteFisico clienteFisico)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM ClienteFisico WHERE codClienteFisico = @CodClienteFisico";

            cmd.Parameters.AddWithValue("@CodClienteFisico", clienteFisico.CodClienteFisico);

            cmd.Connection = con.Conectar();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                clienteFisico.CodClienteFisico = Convert.ToInt32(dr["codClienteFisico"]);
               
                clienteFisico.CpfCliente = dr["cpfCliente"].ToString();

                clienteFisico.CodClienteF = Convert.ToInt32(dr["codClienteF"]);



            }

            dr.Close();
            con.Desconectar();
            return clienteFisico;


        }

        public DataTable FiltrarPorCPF(BLL.ClienteFisico clienteFisico)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codClienteFisico AS 'Código', cpfCliente AS 'CPF', nomeCliente AS 'Nome' FROM ClienteFisico JOIN Cliente ON ClienteFisico.codClienteF = Cliente.codCliente WHERE cpfCliente LIKE @CpfCliente", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@CpfCliente", "%" + clienteFisico.CpfCliente + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }


        #endregion


    }
}
