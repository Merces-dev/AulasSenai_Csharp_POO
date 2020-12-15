using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();
        public float TotalValue;
        public void AddProduct(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void UpdateProduct(int _codigo, Produto _updatedProd)
        {
                carrinho.Find(x => x.Codigo == _codigo).Nome = _updatedProd.Nome;
                carrinho.Find(x => x.Codigo == _codigo).Preco = _updatedProd.Preco;
        }

        public void ReadProduct()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Carrinho:");
            Console.ResetColor();
            System.Console.WriteLine();
            
            foreach (Produto item in carrinho)
            {
                System.Console.WriteLine($"{item.Nome} - R$ {item.Preco}");
            }

        }

        public void DeleteProduct(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void ShowTotal()
        {
            foreach (Produto item in carrinho)
            {
                TotalValue += item.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine();
            System.Console.WriteLine($"Valor Total: {TotalValue}");
        }
        }
    }
