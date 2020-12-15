using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
        Fibonacci rec = new Fibonacci();
        Console.ForegroundColor = ConsoleColor.Blue;
        rec.GerarSequenciaFibonacci(0,1,15);
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine($"Fatorial: {rec.GerarFatorial(5)}");    
        }
    }
}
