using System;

namespace Aula20iFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();
            Cliente clt = new Cliente();
            Restaurante rest = new Restaurante();
            
            rest.Endereco = "Av. Guarulhos, 123";
            pedido.Restaurante = rest.NomeFantasia;
            rest.NomeFantasia = "Straight Up Arroz";

            System.Console.WriteLine("Digite seu nome:");
            clt.Nome = Console.ReadLine();
            System.Console.WriteLine($"Olá {clt.Nome}!");
            pedido.Cliente = clt.Nome;
            clt.EnderecoAtual = "R. do Bamburral, 597";

            pedido.Pedir();
            

        }
    }
}
