namespace Aula20iFood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }

        public string MostrarDados(){
            return $"Nome do restaurante é {NomeFantasia}, e seu endereço é {Endereco}.";
        }
        public string MostrarDados(int estrela){
            return $"Nome do restaurante é {NomeFantasia}.\nO endereço é {Endereco}.\nO restaurante contém {estrela} estrelas michelin.";
        }

    }
}