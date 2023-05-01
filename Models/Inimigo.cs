using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_console.Models;

public class Inimigo
{
    public int InimigoId { get; set; } 
    public string? Nome { get; set; }   
    public int Hp { get; set; }
    public int Mp { get; set; }
    public int Forca { get; set; }
    public int Defesa { get; set; }
    public int Experiencia { get; set; }
    public int Moedas { get; set; }

    public override string ToString()
    {
        return 
        $"Id:{InimigoId} Nome:{Nome} Hp:{Hp} Mp:{Mp} Forca:{Forca} Defesa:{Defesa} Experiencia:{Experiencia} Moedas:{Moedas}";
    }
}
