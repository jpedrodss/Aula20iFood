using System;
namespace Aula20iFood
{
    public class Pedido : Restaurante
    {
        public string[] Itens = new string[2];
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }
        public int contadorItens = 0;


        public string EntregarPedido(){
            return $"Seu pedido do cliente {Cliente}, foi entregue.";
        }
        public void Pedir(){
        System.Console.WriteLine("Deseja fazer um novo pedido?");
            string resposta = Console.ReadLine();
            if(resposta == "y"){
                if(contadorItens < Itens.Length){
                    System.Console.WriteLine("Qual Item você gostaria de pedir?");
                    Itens[contadorItens] = Console.ReadLine();
                    contadorItens++;
                }else{
                    System.Console.WriteLine("Limite de pedido cheio.");
                }
            }
        }
    }
}