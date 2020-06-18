namespace Aula20iFood
{
    public class Pedido : Restaurante
    {
        public string[] Itens = new string[3];
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }

        public string EntregarPedido(){
            return $"Seu pedido do cliente {Cliente}, foi entregue.";
        }
    }
}