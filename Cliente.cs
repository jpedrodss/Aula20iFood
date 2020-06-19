namespace Aula20iFood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }
        public void MostrarDados(){
            System.Console.WriteLine($"Nome do cliente é {Nome}, e seu endereço atual é {EnderecoAtual}.");;
        }
    }
}