using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoVendas_FazendaUrbana.BLL
{
    public class Plantacao
    {
        private int codPlantacao;
        private DateTime dataPlantacao;
        private DateTime horarioPlantacao;
        private int quantidadePlantacao;
        private int codInsumoP;


        public int CodPlantacao { get => codPlantacao; set { codPlantacao = value; } }
        public DateTime DataPlantacao { get => dataPlantacao; set { dataPlantacao = value; } }
        public DateTime HorarioPlantacao { get => horarioPlantacao; set {  horarioPlantacao = value; } }
        public int QuantidadePlantacao { get => quantidadePlantacao; set { quantidadePlantacao = value; } }
        public int CodInsumoP { get => codInsumoP; set { codInsumoP = value; } }



    }
}
