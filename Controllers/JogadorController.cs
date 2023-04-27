using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rpg_console.Context;
using rpg_console.Models;

namespace rpg_console.Controllers
{
    public class JogadorController
    {
        private readonly AppDbContext _context;

        
        public JogadorController(AppDbContext contexto)
        {
            _context = contexto;
        }
        public void CadastrarJogador(){
            try{
                System.Console.WriteLine("Inserir dados do Jogador: \n");
                System.Console.Write("Inserir o Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Inserir a quantidade de HP: ");
                int hp = int.Parse(Console.ReadLine());
                System.Console.Write("Inserir a quantidade de MP: ");
                int mp = int.Parse(Console.ReadLine());
                System.Console.Write("Inserir a quantidade de Forca: ");
                int forca = int.Parse(Console.ReadLine());
                System.Console.Write("Inserir a quantidade de Defesa: ");
                int defesa = int.Parse(Console.ReadLine());
                

                Jogador jogador = new Jogador{
                    Nome = nome,
                    Hp = hp,
                    Mp = mp,
                    Forca = forca,
                    Defesa = defesa,
                    Experiencia = 0
                };

                _context.Add(jogador);
                _context.SaveChanges();
            }
            catch(Exception e){
                System.Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
            System.Console.WriteLine("Jogador Cadastrado com Sucesso!");
            //System.Console.WriteLine(jogador); //override toString ?
    }

        public void VerJogador(){
            System.Console.WriteLine("Informações do jogador: ");
            System.Console.WriteLine(_context.Jogadores.FirstOrDefault(x => x.JogadorId == 1));
        }
        public void VerTodosJogadores(){
            System.Console.WriteLine("Informações dos jogadores: ");
            var jogadores = _context.Jogadores.ToList();

            foreach(Jogador jogador in jogadores ){
                System.Console.WriteLine(jogador.ToString());
            }
        }

        public void ModificarJogadorEspecifico(){
            System.Console.WriteLine("Modificar Jogador Especifico");
            System.Console.Write("Inserir ID do jogador: ");
            int id = int.Parse(Console.ReadLine());

            Jogador jogador = _context.Jogadores.FirstOrDefault(x => x.JogadorId == id);
           
            if(jogador == null){
                System.Console.WriteLine("Jogador não encontrado!");
                return;
            }
            
            System.Console.WriteLine("Informações atuais do jogador: ");
            System.Console.WriteLine(jogador);
            System.Console.WriteLine("Inserir dados do jogador: ");
            System.Console.Write("Inserir o Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Inserir a quantidade de HP: ");
            int hp = int.Parse(Console.ReadLine());
            System.Console.Write("Inserir a quantidade de MP: ");
            int mp = int.Parse(Console.ReadLine());
            System.Console.Write("Inserir a quantidade de Forca: ");
            int forca = int.Parse(Console.ReadLine());
            System.Console.Write("Inserir a quantidade de Defesa: ");
            int defesa = int.Parse(Console.ReadLine());


                jogador.JogadorId = id;
                jogador.Nome = nome;
                jogador.Hp = hp;
                jogador.Mp = mp;
                jogador.Forca = forca;
                jogador.Defesa = defesa;
            
            _context.Jogadores.Update(jogador);
            _context.SaveChanges();

            System.Console.WriteLine("Jogador modificado!");
        }
        public void RemoverJogadorEspecifico(){
            System.Console.WriteLine("Remover Jogador Especifico");
            System.Console.Write("Inserir ID do jogador: ");
            int id = int.Parse(Console.ReadLine());

            Jogador jogador = _context.Jogadores.FirstOrDefault(x => x.JogadorId == id);
           
            if(jogador == null){
                System.Console.WriteLine("Jogador não encontrado!");
                return;
            }

            _context.Jogadores.Remove(jogador);
            _context.SaveChanges();
            return;
        }
    }
}