using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg_console.Context;
using rpg_console.Models;

namespace rpg_console
{
    public class Batalha
    {
        public Jogador jogador { get; set; }
        public Inimigo inimigo { get; set; }
        private readonly AppDbContext contexto;
        public Batalha(Jogador _jogador, Inimigo _inimigo)
        {
            jogador = _jogador;
            inimigo = _inimigo;
            //contexto = context;
        }

        public void LutaCerta(){
            System.Console.WriteLine($"O jogador {jogador.Nome} ganhou a batalha contra {inimigo.Nome}.");
            System.Console.WriteLine($"{inimigo.Nome} deu {inimigo.Experiencia}");
            System.Console.WriteLine($"A experiencia de {jogador.Nome} foi de {jogador.Experiencia} ");
            jogador.Experiencia = jogador.Experiencia + inimigo.Experiencia;
            System.Console.Write($"para {jogador.Experiencia}");
        }
    }
}