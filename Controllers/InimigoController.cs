using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg_console.Context;
using rpg_console.Models;

namespace rpg_console.Controllers
{
    public class InimigoController
    {
        private readonly AppDbContext _context;

        
        public InimigoController(AppDbContext contexto)
        {
            _context = contexto;
        }

         public void CadastrarInimigo(){
            try{
                System.Console.WriteLine("Inserir dados do Inimigo: \n");
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
                System.Console.Write("Inserir a quantidade de Experiencia: ");
                int experiencia = int.Parse(Console.ReadLine());
                System.Console.Write("Inserir a quantidade de Moedas: ");
                int moedas = int.Parse(Console.ReadLine());
                

                Inimigo inimigo = new Inimigo{
                    Nome = nome,
                    Hp = hp,
                    Mp = mp,
                    Forca = forca,
                    Defesa = defesa,
                    Experiencia = experiencia,
                    Moedas = moedas
                };

                _context.Add(inimigo);
                _context.SaveChanges();
            }
            catch(Exception e){
                System.Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
            System.Console.WriteLine("Inimigo Cadastrado com Sucesso!");
    }

        public void VerInimigo(){
            System.Console.WriteLine("Informações do inimigo: ");
            System.Console.WriteLine(_context.Inimigos.FirstOrDefault(x => x.InimigoId == 1));
        }
        public void VerTodosInimigos(){
            System.Console.WriteLine("Informações dos Inimigos: ");
            var inimigos = _context.Inimigos.ToList();

            foreach(Inimigo inimigo in inimigos ){
                System.Console.WriteLine(inimigo.ToString());
            }
        }

        public void ModificarInimigoEspecifico(){
            System.Console.WriteLine("Modificar Inimigo Especifico");
            System.Console.Write("Inserir ID do inimigo: ");
            int id = int.Parse(Console.ReadLine());

            Inimigo inimigo = _context.Inimigos.FirstOrDefault(x => x.InimigoId == id);
           
            if(inimigo == null){
                System.Console.WriteLine("Jogador não encontrado!");
                return;
            }
            
            System.Console.WriteLine("Informações atuais do inimigo: ");
            System.Console.WriteLine(inimigo);
            System.Console.WriteLine("Inserir dados do inimigo: ");
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
            System.Console.Write("Inserir a quantidade de Experiencia: ");
            int experiencia = int.Parse(Console.ReadLine());
            System.Console.Write("Inserir a quantidade de Moedas: ");
            int moedas = int.Parse(Console.ReadLine());

                inimigo.InimigoId = id;
                inimigo.Nome = nome;
                inimigo.Hp = hp;
                inimigo.Mp = mp;
                inimigo.Forca = forca;
                inimigo.Defesa = defesa;
                inimigo.Moedas = moedas;
            
            _context.Inimigos.Update(inimigo);
            _context.SaveChanges();

            System.Console.WriteLine("Inimigo modificado!");
        }
        public void RemoverInimigoEspecifico(){
            System.Console.WriteLine("Remover Inimigo Especifico");
            System.Console.Write("Inserir ID do inimigo: ");
            int id = int.Parse(Console.ReadLine());

            Inimigo inimigo = _context.Inimigos.FirstOrDefault(x => x.InimigoId == id);
           
            if(inimigo == null){
                System.Console.WriteLine("Inimigo não encontrado!");
                return;
            }

            _context.Inimigos.Remove(inimigo);
            _context.SaveChanges();
            return;
        }
    }
}