using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo infoPlayer = new Calculo();
        //1°Opção sem argumentos
        
        System.Console.WriteLine(infoPlayer.CalcularVida());
        System.Console.WriteLine();
        //2°Opção com 1 argumento int

         System.Console.WriteLine(infoPlayer.CalcularVida(100));
         System.Console.WriteLine();
        //3°Opção com 2 argumentos int
    
        System.Console.WriteLine(infoPlayer.CalcularVida(100,40));
        System.Console.WriteLine();
        //3°Opção com 3 argumentos int
    
        System.Console.WriteLine(infoPlayer.CalcularVida(100,40,120));
        System.Console.WriteLine();
        //3°Opção com 3 argumentos int e 1 string
    
        System.Console.WriteLine(infoPlayer.CalcularVida(100,40,120,"bruce"));
        System.Console.WriteLine();
        //4°Opção com 2 argumentos int

        System.Console.WriteLine(("Bruce","Banner"));


        }
    }
}
