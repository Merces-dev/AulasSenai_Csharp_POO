using System;

namespace Aula22Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Conversor.CotacaoDolar = 5.23f;
            System.Console.WriteLine("Dolar para Real: R$"+Conversor.ConverterDolarParaReal(200));
            System.Console.WriteLine("Real para Dolar: $"+Conversor.ConverterRealParaDolar(200));
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Euro para Real: R$"+Conversor.ConverterEuroParaReal(500));
            System.Console.WriteLine("Real para Euro: $"+Conversor.ConverterRealParaEuro(500));

        }
    }
}
