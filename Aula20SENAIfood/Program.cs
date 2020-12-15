using System;

namespace SENAIfood
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente tejota = new Cliente("TeJota", "Av. Paulista");
            Restaurante mcdonalds = new Restaurante("McDonalds", "Brigadeiro Faria Lima");
            Pedido primeiro = new Pedido(); 
            string[] Itens = {"Big Mac","McFish","Cheddar Duplo","Big Tasty" };
            primeiro.Cliente = tejota.NomeCliente;
            primeiro.Restaurante = mcdonalds.NomeFantasia;


            primeiro.FormaDePGTO = "Cartão de Crédito";
            
            System.Console.WriteLine("Qual Item gostaria de adicionar ao seu pedido?");
            System.Console.WriteLine("1 - Big Mac | 2 - McFish | 3 - Cheddar Duplo | 4 - Big Tasty");
            int alim = int.Parse(Console.ReadLine());
            switch(alim){
                case 1:
                Itens[5] = Itens[0];
                break;

                case 2:
                Itens[5] = Itens[1];
                break;

                case 3:
                Itens[5] = Itens[2];
                break;

                default:
                System.Console.WriteLine("Dígito Invalido");
                break;
            } 
            

            if(primeiro.FormaDePGTO == "Cartão de Crédito" ){
                primeiro.PedidoPago = true;

            }else if(primeiro.FormaDePGTO == "Débito" ){
                primeiro.PedidoPago = true;

            }else{
                primeiro.PedidoPago = false;
            }
            if(primeiro.PedidoPago == true){
            Console.Clear();
            Console.WriteLine( mcdonalds.MostrarDados());
            System.Console.WriteLine();
            Console.WriteLine( tejota.MostrarDados());
            System.Console.WriteLine();
            Console.WriteLine( primeiro.EntregarPedido(Itens[5]));                
                
            }
        }
    }
}
