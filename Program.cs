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
            
            rest.NomeFantasia = "Straight Up Arroz";
            rest.Endereco = "Av. Guarulhos, 123";
            System.Console.WriteLine(rest.MostrarDados(5));
            pedido.Restaurante = rest.NomeFantasia;

            // System.Console.WriteLine("Digite seu nome:");
            // clt.Nome = Console.ReadLine();
            // System.Console.WriteLine($"Olá {clt.Nome}!");
            // pedido.Cliente = clt.Nome;
            // clt.EnderecoAtual = "R. do Bamburral, 597";

            // pedido.Pedir();
            

        }
    }
}
