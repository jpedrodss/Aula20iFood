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

            
            clt.Nome = Console.ReadLine();
            pedido.Cliente = clt.Nome;
            clt.EnderecoAtual = "R. do Bamburral, 597";

            pedido.Pedir();
            

        }
    }
}
