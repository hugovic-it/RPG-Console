using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg_console.Context;
using rpg_console.Models;

namespace rpg_console.Controllers
{
    public class EquipamentoArmaController
    {
        private readonly AppDbContext contexto;
        public EquipamentoArmaController(AppDbContext context)
        {
            contexto = context;
        }

        public void VisualizarTodasArma(){
            var resultado = contexto.Armas.ToList(); 
            if(resultado is null){
                System.Console.WriteLine("Resultado nulo");
                return;
            }
            foreach(EquipamentoArma arma in resultado){
                System.Console.WriteLine(arma);
            }
        }
        
        public void VisualizarArmaEspecifica(){
            int id = int.Parse(Console.ReadLine());
            var resultado = contexto.Armas.FirstOrDefault(x => x.EquipamentoArmaId == id);
            if(resultado is null){
                System.Console.WriteLine("Resultado is null");
                return;
            }
            System.Console.WriteLine(resultado);
        }

        public void AdicionarArma(){
            System.Console.WriteLine("Inserir dados da Arma");

            System.Console.Write("Inserir o Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Inserir a Descricao: ");
            string descricao = Console.ReadLine();
            System.Console.WriteLine("Inserir o Ataque");
            int ataque = int.Parse(Console.ReadLine());
            EquipamentoArma arma = new EquipamentoArma{
                Nome = nome,
                Descricao = descricao,
                Ataque = ataque
            };
        }
        
        public void AtualizarArma(){
            System.Console.WriteLine("Atualizar Arma Especifica");
            System.Console.Write("Inserir o ID da arma: ");
            int id = int.Parse(Console.ReadLine());

            EquipamentoArma arma = contexto.Armas.FirstOrDefault(x => x.EquipamentoArmaId == id);
            if(arma is null) {
                System.Console.WriteLine("Arma nao encontrada");
                return;
            }

            System.Console.WriteLine("Inserir dados da Arma");
            System.Console.Write("Inserir o Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Inserir a Descricao: ");
            string descricao = Console.ReadLine();
            System.Console.WriteLine("Inserir o Ataque");
            int ataque = int.Parse(Console.ReadLine());
            
            arma.EquipamentoArmaId = id;
            arma.Nome = nome;
            arma.Descricao = descricao;
            arma.Ataque = ataque;

            
            contexto.Armas.Update(arma);
            contexto.SaveChanges();
            System.Console.WriteLine("Arma Atualizada!");
            return;
        }

        public void DeletarArma(){
            System.Console.WriteLine("Remover Arma");
            System.Console.WriteLine("Inserir id da arma: ");

            int id = int.Parse(Console.ReadLine());
            EquipamentoArma arma = contexto.Armas.FirstOrDefault(x => x.EquipamentoArmaId == id);

            if(arma is null){
                System.Console.WriteLine("Arma invalida");
                return;
            }

            contexto.Armas.Remove(arma);
            contexto.SaveChanges();
        }
    }
}