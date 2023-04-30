using System;
using Microsoft.EntityFrameworkCore;
using rpg_console.Context;
using rpg_console.Controllers;
using rpg_console.Models;

namespace rpg_console;

class Program
{
    static void Main(string[] args)
    {
        AppDbContext contexto = new AppDbContext();
        JogadorController jogadorController = new JogadorController(contexto);
        InimigoController inimigoController = new InimigoController(contexto);
        Batalha batalha = new Batalha(PerfilJogador.Perfil(contexto), PerfilInimigo.Perfil(contexto));

        Console.WriteLine("Olár!");

        int menu = 0;
        int submenu = 0;
        while(menu != 4){
            System.Console.WriteLine(" ============= Menu ============= ");
            System.Console.WriteLine(" 1 -> menu Jogador ");
            System.Console.WriteLine(" 2 -> menu Inimigo ");
            System.Console.WriteLine(" 3 -> menu Batalha");
            System.Console.WriteLine(" 4 -> Sair ");
        
            System.Console.Write("Inserir index de navegação: ");
            menu = int.Parse(Console.ReadLine());
        
            //=======================================================================================================
            while(menu == 1 && submenu != 6){
                System.Console.WriteLine(" ============= Menu Jogador ============= ");
                System.Console.WriteLine(" 1 -> Cadastrar Jogador ");
                System.Console.WriteLine(" 2 -> Visualizar Jogador ");
                System.Console.WriteLine(" 3 -> Visualizar Todos os Jogadores ");
                System.Console.WriteLine(" 4 -> Modificar Jogador Especifico ");
                System.Console.WriteLine(" 5 -> Remover Jogador Especifico ");
                System.Console.WriteLine(" 6 -> Sair ");
                
                System.Console.Write("Inserir index de navegação: ");
                submenu = int.Parse(Console.ReadLine());
            
                switch (submenu){
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
            submenu = 0 ;
            //=======================================================================================================
            while(menu == 2 && submenu !=6){
                System.Console.WriteLine("submenu inimigo");
                System.Console.WriteLine(" 1 -> Cadastrar inimigo ");
                System.Console.WriteLine(" 2 -> Visualizar inimigo ");
                System.Console.WriteLine(" 3 -> Visualizar todos os inimigos ");
                System.Console.WriteLine(" 4 -> Modificar inimigo especifico ");
                System.Console.WriteLine(" 5 -> Remover inimigo especifico ");
                System.Console.WriteLine(" 6 -> Sair ");
                System.Console.Write("Inserir index de navegação: ");
                submenu = int.Parse(Console.ReadLine());
                switch (submenu){
                    case 1:
                        inimigoController.CadastrarInimigo();
                        break;
                    case 2:
                        inimigoController.VerInimigo();
                        break;
                    case 3:
                        inimigoController.VerTodosInimigos();
                        break;
                    case 4:
                        inimigoController.ModificarInimigoEspecifico();
                        break;
                    case 5:
                        inimigoController.RemoverInimigoEspecifico();
                        break;
            
            }
            }
            submenu = 0 ;
            //=======================================================================================================
            while(menu == 3 && submenu !=2)
            {
                System.Console.WriteLine("submenu batalha");
                System.Console.WriteLine(" 1 -> Batalha Certa! ");
                System.Console.WriteLine(" 2 -> Sair");
                submenu = int.Parse(Console.ReadLine());

                switch(submenu){
                    case 1:
                        System.Console.WriteLine("caso 1");
                        batalha.LutaCerta();
                        System.Console.WriteLine("Luta certa finalizada");
                        break;
                    case 2:
                        System.Console.WriteLine("Caso 2");
                        break;
                }
                
            }
            submenu = 0 ;

        
        
    }
}
}
