using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_console.Models;

public class Jogador
{
    public int JogadorId { get; set; }
    public string? Nome { get; set; }
    public int HpMax { get; set; }
    public int Hp { get; set; }
    public int MpMax { get; set; }
    public int Mp { get; set; }
    public int Forca { get; set; }
    public int Defesa { get; set; }
    public int Experiencia { get; set; }
    public int Moedas { get; set; }
    //public EquipamentoArma? Arma { get; set; } //remove ?
    public int EquipamentoArmaId { get; set; } //EF convencao
    public EquipamentoArmadura? Armadura { get; set; }
    public ICollection<Item>? Itens {get; set;}

    public override string ToString()
    {
        if(EquipamentoArmaId is 0){
            return $"Id:{JogadorId} Nome:{Nome} HpMax:{HpMax} MpMax:{MpMax} Forca:{Forca} Defesa:{Defesa} Experiencia:{Experiencia} Moedas:{Moedas}"; 
        }
        
        return $"Id:{JogadorId} Nome:{Nome} HpMax:{HpMax} MpMax:{MpMax} Forca:{Forca} Defesa:{Defesa} Experiencia:{Experiencia} Moedas:{Moedas} ArmaId:{EquipamentoArmaId}"; 

    }
}
