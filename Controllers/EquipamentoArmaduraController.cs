using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using rpg_console.Context;
using rpg_console.Models;

namespace rpg_console.Controllers
{
    public class EquipamentoArmaduraController
    {
        private readonly AppDbContext contexto;
        public EquipamentoArmaduraController(AppDbContext context)
        {
            contexto = context;
        }
        
        public void VisualizarTodasArmadura(){
            var resultado = contexto.Armaduras.ToList(); 
            if(resultado is null){
                System.Console.WriteLine("Resultado nulo");
                return;
            }
            foreach(EquipamentoArmadura arma in resultado){
                System.Console.WriteLine(arma);
            }
        }        

        public void VisualizarArmaduraEspecifica(){
            System.Console.Write("Inserir o id da Armadura: ");
            int id = int.Parse(Console.ReadLine());
            var resultado = contexto.Armaduras.FirstOrDefault(x => x.EquipamentoArmaduraId == id);
            if(resultado is null){
                System.Console.WriteLine("Resultado is null");
                return;
            }
            System.Console.WriteLine(resultado);
        }

        public void AdicionarArmadura(){
            System.Console.WriteLine("Inserir dados da Armadura");

            System.Console.Write("Inserir o Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Inserir a Descricao: ");
            string descricao = Console.ReadLine();
            System.Console.WriteLine("Inserir o Defesa");
            int defesa = int.Parse(Console.ReadLine());
            EquipamentoArmadura armadura = new EquipamentoArmadura{
                Nome = nome,
                Descricao = descricao,
                Defesa = defesa
            };
            contexto.Armaduras.Add(armadura);
            contexto.SaveChanges();
        }


        public void AtualizarArmadura(){
            System.Console.WriteLine("Atualizar Armadura Especifica");
            System.Console.Write("Inserir o ID da armadura: ");
            int id = int.Parse(Console.ReadLine());

            EquipamentoArmadura armadura = contexto.Armaduras.FirstOrDefault(x => x.EquipamentoArmaduraId == id);
            if(armadura is null) {
                System.Console.WriteLine("Armadura nao encontrada");
                return;
            }

            System.Console.WriteLine("Inserir dados da Armadura");
            System.Console.Write("Inserir o Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Inserir a Descricao: ");
            string descricao = Console.ReadLine();
            System.Console.Write("Inserir a Defesa: ");
            int defesa = int.Parse(Console.ReadLine());
            
            armadura.EquipamentoArmaduraId = id;
            armadura.Nome = nome;
            armadura.Descricao = descricao;
            armadura.Defesa = defesa;

            
            contexto.Armaduras.Update(armadura);
            contexto.SaveChanges();
            System.Console.WriteLine("Armadura Atualizada!");
            return;
        }
        public void DeletarArmadura(){
            System.Console.WriteLine("Remover Armadura");
            System.Console.WriteLine("Inserir id da armadura: ");

            int id = int.Parse(Console.ReadLine());
            EquipamentoArmadura armadura = contexto.Armaduras.FirstOrDefault(x => x.EquipamentoArmaduraId == id);

            if(armadura is null){
                System.Console.WriteLine("Armadura invalida");
                return;
            }

            contexto.Armaduras.Remove(armadura);
            contexto.SaveChanges();
        }



    }
}