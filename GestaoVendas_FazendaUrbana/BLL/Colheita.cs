using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas_FazendaUrbana.BLL
{
    public class Colheita
    {
        private int codColheita;
        private DateTime dataColheita;
        private DateTime horarioColheita;
        private int quantidadeColheita;
        private int codProdutoC;

        public int CodColheita { get => codColheita; set { codColheita = value; } }
        public DateTime DataColheita { get => dataColheita; set { dataColheita = value; } }
        public DateTime HorarioColheita { get => horarioColheita; set { horarioColheita = value; } }
        public int QuantidadeColheita { get => quantidadeColheita; set { quantidadeColheita = value; } }
        public int CodProdutoC { get => codProdutoC; set { codProdutoC = value; } }


    }
}
