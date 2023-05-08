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
            //int jogadorId = int.Parse(Console.ReadLine());
            //int armaId = int.Parse(Console.ReadLine());
            var jogador = contexto.Jogadores.FirstOrDefault(x => x.JogadorId == jogadorId);

            if(jogador is null){
                System.Console.WriteLine("Jogador nulo");
                return;
            }
            var arma = contexto.Armas.FirstOrDefault(X => X.EquipamentoArmaId == armaId);
            if(arma is null){
                System.Console.WriteLine("Arma nula");
                return;
            }

            if(jogador.Arma != null){
                jogador.Forca = jogador.Forca - jogador.Arma.Ataque; //removendo o status da arma que sera removida
            }

            jogador.Arma = arma;  //recebendo a nova arma
            jogador.Forca = jogador.Forca + arma.Ataque; //aplicando o status da nova arma

            //ao reiniciar a aplicação, o codigo persiste os status do jogador, mas não o da arma equipada
            contexto.Jogadores.Update(jogador);
            contexto.Jogadores.Update(jogador);
            contexto.SaveChanges();
            System.Console.WriteLine("Arma equipada com sucesso!");

        }

        public void EquiparArmadura(int jogadorId, int armaduraId){
            
        }
    }
}