using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 4;
            p1.Nome = "Sonic";
            p1.Preco = 255f;

            p1.Cadastrar(p1);
            p1.Remover("COD");

            Produto alterado = new Produto();
            alterado.Codigo = 3;
            alterado.Nome = "Farcry 3";
            alterado.Preco = 75;
            List<Produto> lista = p1.Ler();

            foreach (Produto item in lista)
            {
                Console.WriteLine($"R$ {item.Preco}, Nome: {item.Nome}");
            }
        }
    }
}
