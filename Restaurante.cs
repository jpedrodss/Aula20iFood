namespace Aula20iFood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }

        public string MostrarDados(){
            return $"Nome do cliente é {NomeFantasia}, e seu endereço atual é {Endereco}.";
        }

    }
}