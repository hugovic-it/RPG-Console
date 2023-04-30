using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg_console.Context;
using rpg_console.Models;

namespace rpg_console
{
public static class PerfilJogador
{
    public static Jogador Perfil(AppDbContext contexto)
    {
       //System.Console.Write("Inserir id do perfil ativo:");
        int id = 1;
        Jogador jogador = contexto.Jogadores.First(x => x.JogadorId == id);
        return jogador;
    }
}
}