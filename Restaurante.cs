using System;

namespace Aula20iFood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        
        public Restaurante(string _nomeFantasia){
            NomeFantasia = _nomeFantasia;
        }
        public void MostrarDados(){
            Console.WriteLine($"Nome do restaurante é {NomeFantasia} situado em {Endereco}.\n");
        }
    }
}