using System;
using Microsoft.EntityFrameworkCore;
using rpg_console.Context;
using rpg_console.Controllers;
using rpg_console.Models;
using rpg_console.Services;

namespace rpg_console;

class Program
{
    static void Main(string[] args)
    {
        AppDbContext contexto = new AppDbContext();
        JogadorController jogadorController = new JogadorController(contexto);
        InimigoController inimigoController = new InimigoController(contexto);
        Batalha batalha = new Batalha(PerfilJogador.Perfil(contexto), PerfilInimigo.Perfil(contexto), contexto);
        EquipamentoArmaController armaController = new EquipamentoArmaController(contexto);
        EquipamentoArmaduraController armaduraController = new EquipamentoArmaduraController(contexto);
        JogadorService jogadorService = new JogadorService(contexto);

        int menu = 0;
        int submenu = 0;
        while(menu != 7){
            System.Console.WriteLine(" ============= Menu ============= ");
            System.Console.WriteLine(" 1 -> menu Jogador ");
            System.Console.WriteLine(" 2 -> menu Inimigo ");
            System.Console.WriteLine(" 3 -> menu Batalha");
            System.Console.WriteLine(" 4 -> menu Arma");
            System.Console.WriteLine(" 5 -> menu Armadura");
            System.Console.WriteLine(" 6 -> menu JogadorController");
            System.Console.WriteLine(" 7 -> Sair ");
        
            System.Console.Write("Inserir index de navegação: ");
            try{
            menu = int.Parse(Console.ReadLine());
            } catch (Exception e){
                System.Console.WriteLine(e);
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Inserir um valor valido!");
                Console.ResetColor();
                menu = 0;
            }
        
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
                try{
                    submenu = int.Parse(Console.ReadLine());
                } catch (Exception e){
                    System.Console.WriteLine(e);
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Inserir um valor valido!");
                    Console.ResetColor();
                    submenu = 0;
                }                

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


                
                try{
                    submenu = int.Parse(Console.ReadLine());
                } catch (Exception e){
                    System.Console.WriteLine(e);
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Inserir um valor valido!");
                    Console.ResetColor();
                    submenu = 0;
                }                

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
            while(menu == 3 && submenu !=3)
            {
                System.Console.WriteLine("submenu batalha");
                System.Console.WriteLine(" 1 -> Batalha Certa ");
                System.Console.WriteLine(" 2 -> Batalha Normal");
                System.Console.WriteLine(" 3 -> Sair");

                
                try{
                    submenu = int.Parse(Console.ReadLine());
                } catch (Exception e){
                    System.Console.WriteLine(e);
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Inserir um valor valido!");
                    Console.ResetColor();
                    submenu = 0;
                }


                switch(submenu){
                    case 1:
                        batalha.LutaCerta();
                        break;
                    case 2:
                        batalha.LutaNormal();
                        break;
                }
                
            }
            submenu = 0 ;

            //=======================================================================================================
            while(menu == 4 && submenu != 6){
                System.Console.WriteLine("submenu arma");
                System.Console.WriteLine("1 -> Visualizar todas as armas");
                System.Console.WriteLine("2 -> Visualizar arma especifica");
                System.Console.WriteLine("3 -> Adicionar arma");
                System.Console.WriteLine("4 -> Atualizar arma");
                System.Console.WriteLine("5 -> Remover arma");
                System.Console.WriteLine("6 -> Sair");

                
            try{
                submenu = int.Parse(Console.ReadLine());
            } catch (Exception e){
                System.Console.WriteLine(e);
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Inserir um valor valido!");
                Console.ResetColor();
                submenu = 0;
            }


                switch(submenu){
                    case 1:
                        armaController.VisualizarTodasArma();
                        break;
                    case 2:
                        armaController.VisualizarArmaEspecifica();
                        break;
                    case 3:
                        armaController.AdicionarArma();
                        break;
                    case 4:
                        armaController.AtualizarArma();
                        break;
                    case 5:
                        armaController.DeletarArma();
                        break;
                }

            }
            submenu = 0;

            //=======================================================================================================
            while(menu == 5 && submenu != 6){
                System.Console.WriteLine("submenu armadura");
                System.Console.WriteLine("1 -> Visualizar todas as armaduras");
                System.Console.WriteLine("2 -> Visualizar armadura especifica");
                System.Console.WriteLine("3 -> Adicionar armadura");
                System.Console.WriteLine("4 -> Atualizar armadura");
                System.Console.WriteLine("5 -> Remover armadura");
                System.Console.WriteLine("6 -> Sair");

                try{
                    submenu = int.Parse(Console.ReadLine());
                } catch (Exception e){
                    System.Console.WriteLine(e);
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Inserir um valor valido!");
                    Console.ResetColor();
                    submenu = 6;
                }

                switch(submenu){
                    case 1:
                        armaduraController.VisualizarTodasArmadura();
                        break;
                    case 2:
                        armaduraController.VisualizarArmaduraEspecifica();
                        break;
                    case 3:
                        armaduraController.AdicionarArmadura();
                        break;
                    case 4:
                        armaduraController.AtualizarArmadura();
                        break;
                    case 5:
                        armaduraController.DeletarArmadura();
                        break;
                }
               
            }
            submenu = 0;

            //=======================================================================================================
            while(menu == 6 && submenu != 2){
                System.Console.WriteLine("submenu JogadorController");
                System.Console.WriteLine(" 1 -> Equipar Arma");
                System.Console.WriteLine(" 2 -> Sair");
                
                try{
                    submenu = int.Parse(Console.ReadLine());
                } catch (Exception e){
                    System.Console.WriteLine(e);
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Inserir um valor valido!");
                    Console.ResetColor();
                    submenu = 0;
                }
                
                switch(submenu){
                    case 1:
                        System.Console.Write("Inserir o ID do Jogador:");
                        int jogadorId = int.Parse(Console.ReadLine());
                        System.Console.Write("Inserir o ID da Arma:");
                        int armaId = int.Parse(Console.ReadLine());
                        //HERE ----
                        jogadorService.EquiparArma(jogadorId,armaId);
                        break;
                    case 2:

                    break;
                };
            }
            submenu = 0;
        }
    }
}
