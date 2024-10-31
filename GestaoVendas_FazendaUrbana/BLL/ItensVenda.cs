using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas_FazendaUrbana.BLL
{
    public class ItensVenda
    {
        private int codItensVenda;
        private int quantidadeItensVenda;
        private double valorTotalItensVenda;
        private int codVendaIV;
        private int codProdutoIV;

        public int CodItensVenda { get => codItensVenda; set { codItensVenda = value; } }
        public int QuantidadeItensVenda { get => quantidadeItensVenda; set { quantidadeItensVenda = value; } }
        public double ValorTotalItensVenda { get => valorTotalItensVenda; set { valorTotalItensVenda = value; } }
        public int CodVendaIV { get => codVendaIV; set { codVendaIV = value; } }
        public int CodProdutoIV { get => codProdutoIV; set { codProdutoIV = value; } }
    }
}
