using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas_FazendaUrbana.BLL
{
    public class ClienteJuridico: Cliente
    {
        private int codClienteJuridico;
        private string cnpjCliente;
        private string razaoSocialCliente;
        private int codClienteJ;

        public int CodClienteJuridico { get => codClienteJuridico; set { codClienteJuridico = value; } }
        public string CnpjCliente { get => cnpjCliente; set { cnpjCliente = value; } }

        public string RazaoSocialCliente { get => razaoSocialCliente; set { razaoSocialCliente = value; } }

        public int CodClienteJ { get => codClienteJ; set { codClienteJ = value; } }
    }
}
