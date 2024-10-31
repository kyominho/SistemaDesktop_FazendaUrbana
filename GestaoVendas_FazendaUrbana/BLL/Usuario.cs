using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas_FazendaUrbana.BLL
{
    public class Usuario
    {
        private int codUsuario;
        private string nomeUsuario;
        private int nivelAcesso;
        private string usuario;
        private string senha;


        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public int NivelAcesso { get => nivelAcesso; set => nivelAcesso = value; }
        public string User { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }


    }
}

