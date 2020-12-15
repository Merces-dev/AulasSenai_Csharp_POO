using System;
namespace Aula18Dojo1
{
    class Program
    {    
        static void Main(string[] args)
        {       
            Jogador messi = new Jogador();
            messi.Peso = 80f;
            System.Console.WriteLine("Digite o Nome do jogador: ");
            messi.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite a Posição do jogador: ");
            messi.Posicao = Console.ReadLine();
            System.Console.WriteLine("Digite a Data de Nascimento do jogador: ");
            messi.Nascimento = DateTime.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("O jogador tem "+messi.CalcularIdade()+" anos de idade.");
            Console.WriteLine(messi.VerificarAposentadoria());
        }
    }
}

