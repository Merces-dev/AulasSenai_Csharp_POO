namespace SENAIfood
{
    public class Pedido
    {
        public string FormaDePGTO { get; set; }
        public bool PedidoPago { get; set; }
        public string Cliente { get; set; }
        public string Restaurante { get; set; }
        public string EntregarPedido(string Itens) { 
        return "Forma de Pagamento: "+ FormaDePGTO+ " | "+ "Itens: "+ Itens ;
        }
    }
}