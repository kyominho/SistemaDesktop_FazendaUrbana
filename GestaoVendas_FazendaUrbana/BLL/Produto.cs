using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas_FazendaUrbana.BLL
{
    public class Produto
    {
        private int codProduto;
        private string nomeProduto;
        private int estoqueProduto;
        private double precoProduto;
        private DateTime dataValidadeProduto;

        public int CodProduto { get => codProduto; set { codProduto = value; } }

        public string NomeProduto { get => nomeProduto; set { nomeProduto = value; } }

        public int EstoqueProduto { get => estoqueProduto; set { estoqueProduto = value; } }

        public double PrecoProduto { get => precoProduto; set { precoProduto = value; } }

        public DateTime DataValidadeProduto { get => dataValidadeProduto; set { dataValidadeProduto = value; } }
    }
}
