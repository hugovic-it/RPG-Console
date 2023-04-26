using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg_console.Context;
using rpg_console.Models;

namespace rpg_console.Controllers
{
    public class JogadorController
    {
        private readonly AppDbContext _context;
        public void CadastrarJogador(){

            System.Console.WriteLine("Inserir dados do Jogador: \n");
            System.Console.Write("Inserir o Nome: ");
            string? nome = Console.ReadLine();
            System.Console.Write("Inserir a quantidade de HP: ");
            int? hp = int.Parse(Console.ReadLine());
            System.Console.Write("Inserir a quantidade de MP: ");
            int? mp = int.Parse(Console.ReadLine());
            System.Console.Write("Inserir a quantidade de Forca: ");
            int? forca = int.Parse(Console.ReadLine());
            System.Console.Write("Inserir a quantidade de Defesa: ");
            int? defesa = int.Parse(Console.ReadLine());

            Jogador jogador = new Jogador{
                Nome = nome,
                Hp = hp.GetValueOrDefault(),
                Mp = mp.GetValueOrDefault(),
                Forca = forca.GetValueOrDefault(),
                Defesa = defesa.GetValueOrDefault()  
            };

            _context.Add(jogador);
            _context.SaveChanges();

            System.Console.WriteLine("Jogador Cadastrado com Sucesso!");
            //System.Console.WriteLine(jogador); //override toString ?
        }

        public void VerJogador(){
            System.Console.WriteLine("Inserir o numero do jogador que deseja visualizar: ");
            int seletor = int.Parse(Console.ReadLine());

            _context.Jogadores.FirstOrDefault(x => x.JogadorId == seletor);

        }
    }
}