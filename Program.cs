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

        //
        

        int menu = 0;
        while( menu != 4){

            System.Console.WriteLine(" ============= Menu ============= ");
            System.Console.WriteLine(" 1 -> Cadastrar Jogador ");
            System.Console.WriteLine(" 2 -> Visualizar Jogador ");
            System.Console.WriteLine(" 3 -> Visualizar Todos os Jogadores ");
            System.Console.WriteLine(" 4 -> Sair ");

            System.Console.Write("Inserir index de navegação: ");
            menu = int.Parse(Console.ReadLine());
           

            //switch case
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
            }

        }
        System.Console.WriteLine("Fim menu!");
    }
}
