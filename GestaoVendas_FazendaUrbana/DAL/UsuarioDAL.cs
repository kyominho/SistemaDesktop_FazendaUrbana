using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace GestaoVendas_FazendaUrbana.DAL
{
    public class UsuarioDAL
    {

        Conexao con = new Conexao();

        public BLL.Usuario Logar(BLL.Usuario usuario)

        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "spLogin";
            cmd.CommandType = CommandType.StoredProcedure;

            // cmd.CommandText = "SELECT * FROM Usuario WHERE usuario = @Usuario AND senha = @Senha";

            cmd.Parameters.AddWithValue("@Usuario", usuario.User);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);


            cmd.Connection = con.Conectar();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                usuario.CodUsuario = Convert.ToInt16(dr["codUsuario"]);
                usuario.NomeUsuario = dr["nomeUsuario"].ToString();
                usuario.NivelAcesso = Convert.ToInt16(dr["nivelAcesso"]);
                usuario.User = dr["usuario"].ToString();

            }


            dr.Close();
            con.Desconectar();
            return usuario;


        }

        public void CadastrarUsuario(BLL.Usuario usuario)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spCadastrarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario);
            cmd.Parameters.AddWithValue("@NivelAcesso", usuario.NivelAcesso);
            cmd.Parameters.AddWithValue("@Usuario", usuario.User);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);

            cmd.Connection = con.Conectar(); //abrindo conexao
            cmd.ExecuteNonQuery(); //executar comando
            con.Desconectar(); //fechando conexao

        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codUsuario AS 'Código', nomeUsuario AS 'Nome', nivelAcesso AS 'Nível Acesso', usuario AS 'Usuário', senha AS 'Senha' FROM Usuario", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;


        }

        public DataTable FiltrarPorNome (BLL.Usuario usuario)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT codUsuario AS 'Código', nomeUsuario AS 'Nome', nivelAcesso AS 'Nível Acesso', usuario AS 'Usuário', senha AS 'Senha' FROM Usuario WHERE nomeUsuario LIKE @NomeUsuario", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario + "%");
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spExcluirUsuario";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CodUsuario", usuario.CodUsuario);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void Alterar(BLL.Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "spAlterarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario);
            cmd.Parameters.AddWithValue("@NivelAcesso", usuario.NivelAcesso);
            cmd.Parameters.AddWithValue("@Usuario", usuario.User);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@CodUsuario", usuario.CodUsuario);

            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();

        }

        public BLL.Usuario Retornar(BLL.Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Usuario WHERE codUsuario = @CodUsuario ";

            cmd.Parameters.AddWithValue("@CodUsuario", usuario.CodUsuario);

            cmd.Connection = con.Conectar();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                usuario.CodUsuario = Convert.ToInt32(dr["codUsuario"]);
                usuario.NomeUsuario = dr["nomeUsuario"].ToString();
                usuario.NivelAcesso = Convert.ToInt32(dr["nivelAcesso"]);
                usuario.User = dr["usuario"].ToString();
                usuario.Senha = dr["senha"].ToString();
            }

            dr.Close();
            con.Desconectar();
            return usuario;


        }
    }

}
