using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rpg_console.Context;
using rpg_console.Models;

namespace rpg_console
{
    public class Batalha
    {
        public Jogador jogador { get; set; }
        public Inimigo inimigo { get; set; }

        private readonly DbContext contexto;
        public Batalha(Jogador _jogador, Inimigo _inimigo, DbContext _contexto)
        {
            jogador = _jogador;
            inimigo = _inimigo;
            contexto = _contexto;
        }
        public void LutaNormal(){
        inimigo.Hp = inimigo.HpMax;
        //jogador.Hp = jogador.HpMax;  //corrigido!!!
        System.Console.WriteLine($"O jogador {jogador.Nome} deseja lutar? (y/n)");
        string resposta = Console.ReadLine();
        if (resposta == "n" || resposta == "N"){
            System.Console.WriteLine("O jogador deixou a batalha");
            return;
        }
        int i=1;
        System.Console.WriteLine($"Batalha: {jogador.Nome} x {inimigo.Nome}");
        while(jogador.Hp > 0 || inimigo.Hp>0){
            System.Console.WriteLine($"{i}° turno");

            int dano  = jogador.Forca - inimigo.Defesa ;   
            System.Console.WriteLine($"O jogador {jogador.Nome} ataca e causa {dano} de dano ao Inimigo {inimigo.Nome}");
            System.Console.WriteLine($"O Inimigo {inimigo.Nome} fica com {inimigo.Hp}HP");
            inimigo.Hp = inimigo.Hp - dano;
            if(inimigo.Hp <= 0 ){
                jogador.Moedas = jogador.Moedas + inimigo.Moedas;
                jogador.Experiencia = jogador.Experiencia + inimigo.Experiencia;
                System.Console.WriteLine($"O inimigo {inimigo.Nome} fica com {inimigo.Hp}HP e é finalizado!");
                System.Console.WriteLine($"O jogador ganhou {inimigo.Experiencia} experiencia e {inimigo.Moedas} moedas");
               
                contexto.Update(jogador);
                contexto.SaveChanges();
                return;
            }
            
            dano = inimigo.Forca * 2 - jogador.Defesa;  
            jogador.Hp = jogador.Hp - dano;  
            System.Console.WriteLine($"O inimigo {inimigo.Nome} ataca e causa {dano} de dano ao Jogador {jogador.Nome}");
            System.Console.WriteLine($"O Jogador {jogador.Nome} fica com {jogador.Hp}HP");

        if (jogador.Hp <= 0){
            
            jogador.Moedas = jogador.Moedas / 2;
            jogador.Hp = 100;
            inimigo.Hp = 0; // <---gambiarra para sair do loop;
            System.Console.WriteLine($"O jogador {jogador.Nome} foi finalizado!");
            System.Console.WriteLine($"O jogador {jogador.Nome} perdeu metade das moedas!");
            System.Console.WriteLine($"A Saude do jogador foi restaurada em {jogador.Hp}");

            contexto.Update(jogador);
            contexto.SaveChanges();
            return;
            
        }
         i++;
         Console.ReadKey();
        }
 

        }

        public void LutaCerta(){
            System.Console.WriteLine($"O jogador {jogador.Nome} ganhou a batalha contra {inimigo.Nome}.");
            System.Console.WriteLine($"{inimigo.Nome} deu {inimigo.Experiencia}");
            System.Console.WriteLine($"A experiencia de {jogador.Nome} foi de {jogador.Experiencia} ");
            jogador.Experiencia = jogador.Experiencia + inimigo.Experiencia;
            System.Console.Write($"para {jogador.Experiencia}");

            contexto.Update(jogador);
            contexto.SaveChanges();
        }
    }
}