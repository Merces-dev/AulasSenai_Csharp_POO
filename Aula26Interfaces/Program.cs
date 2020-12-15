using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            Produto p1 = new Produto(1, "Farcry 3",70.89f);
            Produto p2 = new Produto(2, "The Last Of Us II",250.89f);
            Produto p3 = new Produto(3, "FIFA 21",350.89f);
            Produto p4 = new Produto(4, "Call Of Duty - Modern Warfare 2",90.89f);

            cart.AddProduct(p1);
            cart.AddProduct(p2);
            cart.AddProduct(p3);
            cart.AddProduct(p4);

            cart.DeleteProduct(p4);

            Produto Updatedprod = new Produto(5,"Pro Evolution Soccer 2021",250f);
            cart.UpdateProduct(3,Updatedprod);
            cart.ReadProduct();
            cart.ShowTotal();
        }
    }
}
