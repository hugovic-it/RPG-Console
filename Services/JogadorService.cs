using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg_console.Context;

namespace rpg_console.Services
{
    public class JogadorService
    {
        private readonly AppDbContext contexto;
        public JogadorService(AppDbContext context)
        {
            contexto = context;
        }

        public void EquiparArma(int jogadorId, int armaId){
            var jogador = contexto.Jogadores.FirstOrDefault(x => x.JogadorId == jogadorId);

            if(jogador is null){
                System.Console.WriteLine("Jogador nulo");
                return;
            }
            var arma = contexto.Jogadores.FirstOrDefault(X => X.Arma.EquipamentoArmaId == armaId);
            if(arma is null){
                System.Console.WriteLine("Arma nula");
                return;
            }

            if(jogador.Arma != null){
                jogador.Forca = jogador.Arma.Ataque;
            }
            jogador.Arma = arma;
            jogador.Forca =+ arma.Forca;
            System.Console.WriteLine("Arma equipada com sucesso!");
        }

        public void EquiparArmadura(int jogadorId, int armaduraId){

        }
    }
}