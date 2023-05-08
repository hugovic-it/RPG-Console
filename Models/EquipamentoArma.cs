using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_console.Models
{
    public class EquipamentoArma
    {
        public int EquipamentoArmaId { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Ataque { get; set; }

        public override string ToString()
        {
            return $"Id: {EquipamentoArmaId}\nNome: {Nome}\nDescricao: {Descricao}\nAtaque: {Ataque}";
        }
    }
}