using System;

namespace Aula20iFood
{
    public class Pedido
    {
        public string[] Itens = new string[3];
        public Cliente Cliente { get; set; }
        public Restaurante Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }
        public string StatusPedido { get; set; }
        public int contadorItens = 0;
        
        public void Pedir(){
            try{
                System.Console.WriteLine("Deseja fazer um novo pedido? (y = sim / n = não)");
                    string resposta = Console.ReadLine();
                    if(resposta == "y"){

                        do{
                                System.Console.WriteLine("Qual item você gostaria de pedir?");
                                Itens[contadorItens] = Console.ReadLine();
                                contadorItens++;
                                
                        } while(contadorItens < Itens.Length);

                        if (contadorItens >= Itens.Length) {
                            System.Console.WriteLine("\nLimite de pedido alcançado.\n");
                        }

                        System.Console.WriteLine($"Confirmar o pedido com os seguintes itens? (y = sim / n = nao)\n -{Itens[0]}\n -{Itens[1]}\n -{Itens[2]}");
                        string confirmacao = Console.ReadLine();

                        if(confirmacao == "y"){
                            System.Console.WriteLine($"Como deseja efetuar o pagamento?");
                            FormaDePGTO = Console.ReadLine();
                            System.Console.WriteLine($"Seu pedido será pago em {FormaDePGTO}.\n");
                            System.Console.WriteLine($"Pedido concluido em {DateTime.Now}.\nItens pedidos: {Itens[0]}, {Itens[1]} e {Itens[2]}.");

                        } else if(confirmacao == "n"){
                            contadorItens = 0;
                            Itens[0] = null;
                            Itens[1] = null;
                            Itens[2] = null;
                            Pedir();

                        } else {
                            System.Console.WriteLine("Tente novamente.");
                            contadorItens = 0;
                            Itens[0] = null;
                            Itens[1] = null;
                            Itens[2] = null;
                            Pedir();

                        }

                    } else if (resposta == "n"){
                        System.Console.WriteLine("Pedido cancelado.");

                    } else {
                        System.Console.WriteLine("Insira um comando válido.");

                    }

            }catch (Exception e){
                System.Console.WriteLine(e);

            }
        }

        public string EntregarPedido(){
            return $"{Cliente} seu pedido está a caminho.";
            
        }
    }
}