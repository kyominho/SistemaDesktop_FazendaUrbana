using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;



namespace GestaoVendas_FazendaUrbana.DAL
{
    public class Conexao
    {
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Sistema_GestaoFazenda"].ConnectionString);

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }
            return con;
        }


        public void Desconectar()
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
        }


    }
}
