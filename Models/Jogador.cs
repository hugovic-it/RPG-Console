using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_console.Models;

public class Jogador
{
    public int JogadorId { get; set; }
    public string? Nome { get; set; }
    public int Hp { get; set; }
}
