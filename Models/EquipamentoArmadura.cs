using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_console.Models
{
    public class EquipamentoArmadura
    {
        public int EquipamentoArmaduraId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Defesa { get; set; }

        public override string ToString()
        {
            return $"Id:{EquipamentoArmaduraId} Nome{Nome} \n Descricao:{Descricao}";
        }
    }
}