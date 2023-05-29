using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using rpg_console.Context;

namespace rpg_console.Models;

public class Jogador
{
 
    private readonly AppDbContext contexto = new AppDbContext{};

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
    [JsonIgnore]
    public int EquipamentoArmaId { get; set; } //EF convencao
    public EquipamentoArmadura? Armadura { get; set; }
    public ICollection<Item>? Itens {get; set;}

    public override string ToString()
    {
        
        
        if(EquipamentoArmaId is 0){
            return $"Id:{JogadorId} Nome:{Nome} HpMax:{HpMax} MpMax:{MpMax} Forca:{Forca} Defesa:{Defesa} Experiencia:{Experiencia} Moedas:{Moedas}"; 
        }
        

        var resultado = contexto.Armas.SingleOrDefault(x => x.EquipamentoArmaId == EquipamentoArmaId);
        return $"Id:{JogadorId} Nome:{Nome} HpMax:{HpMax} MpMax:{MpMax} Forca:{Forca} Defesa:{Defesa} Experiencia:{Experiencia} Moedas:{Moedas} ArmaId:{EquipamentoArmaId} ArmaNome:{resultado} "; 

    }
}
