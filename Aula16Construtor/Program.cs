using System;

namespace Aula16Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instância sem argumentos
            Produto videogame = new Produto();
            videogame.Nome = "Playstation 5";
            System.Console.WriteLine("--------------------------");
            //instância com só 1 argumento
            Produto tenis = new Produto(19);
            System.Console.WriteLine(tenis.Codigo);
            System.Console.WriteLine("--------------------------");
            //instância com todos os atributos como argumento
            Produto oculos = new Produto(22, "Oakley", "Rosa", 120);
            System.Console.WriteLine(oculos.Codigo);
            System.Console.Write(oculos.Nome);
            System.Console.WriteLine(" "+oculos.Descricao);
            System.Console.WriteLine(oculos.Estoque);

        }
    }
}