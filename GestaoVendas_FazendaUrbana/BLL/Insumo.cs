using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas_FazendaUrbana.BLL
{
    public class Insumo
    {
        private int codInsumo;
        private string nomeInsumo;
        private int estoqueInsumo;
        private DateTime dataValidadeInsumo;
        private double precoInsumo;

        public int CodInsumo { get => codInsumo; set { codInsumo = value; } }
        public string NomeInsumo { get => nomeInsumo; set { nomeInsumo = value; } }
        public int EstoqueInsumo { get => estoqueInsumo;  set { estoqueInsumo = value; } }   
        public DateTime DataValidadeInsumo { get => dataValidadeInsumo; set { dataValidadeInsumo = value; } }
        public double PrecoInsumo { get => precoInsumo; set { precoInsumo = value; } }

    }
}
