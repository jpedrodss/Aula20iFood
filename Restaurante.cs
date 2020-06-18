using System;

namespace Aula20iFood
{
    public class Restaurante : Pedido
    {
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        
        public void MostrarDados(){
            System.Console.WriteLine($"Logar como {NomeFantasia} situado em {Endereco}?");
            string resposta = Console.ReadLine();

            if(resposta == "y"){
                System.Console.WriteLine($"Olá, {NomeFantasia}!");    
                System.Console.WriteLine($"Você tem {Itens} pedidos novos.\nO que deseja fazer?\n 1 - Ver pedidos\n 0 - Deslogar");
                string resposta1 = Console.ReadLine();

                do{
                    switch(resposta1){

                        case "1":
                            System.Console.WriteLine($"{Itens}");
                        break;

                        case "0":
                            System.Console.WriteLine($"Deslogado com sucesso");
                        break;

                        default:
                        System.Console.WriteLine("Digite uma opção válida.");
                        break;
                        
                    }    
                }while(resposta1 != "0");
            }else {
                System.Console.WriteLine("entao beleza irmao");
            }
        }
    }
}