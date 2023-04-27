using System;
using Microsoft.EntityFrameworkCore;
using rpg_console.Context;
using rpg_console.Controllers;

namespace rpg_console;

class Program
{
    static void Main(string[] args)
    {
        AppDbContext contexto = new AppDbContext();
        JogadorController jogadorController = new JogadorController(contexto);

        Console.WriteLine("Olár!");

        int menu = 0;
        while(menu != 6){

            System.Console.WriteLine(" ============= Menu ============= ");
            System.Console.WriteLine(" 1 -> Cadastrar Jogador ");
            System.Console.WriteLine(" 2 -> Visualizar Jogador ");
            System.Console.WriteLine(" 3 -> Visualizar Todos os Jogadores ");
            System.Console.WriteLine(" 4 -> Modificar Jogador Especifico ");
            System.Console.WriteLine(" 5 -> Remover Jogador Especifico ");
            System.Console.WriteLine(" 6 -> Sair ");

            System.Console.Write("Inserir index de navegação: ");
            menu = int.Parse(Console.ReadLine());
           
            switch (menu){
                case 1:
                    jogadorController.CadastrarJogador();
                    break;
                case 2:
                    jogadorController.VerJogador();
                    break;
                case 3:
                    jogadorController.VerTodosJogadores();
                    break;
                case 4:
                    jogadorController.ModificarJogadorEspecifico();
                    break;
                case 5:
                    jogadorController.RemoverJogadorEspecifico();
                    break;
            }
        }
        System.Console.WriteLine("Fim menu!");
    }
}
