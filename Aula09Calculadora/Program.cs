using System;

namespace Aula09Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        Calculadora one = new Calculadora();
        System.Console.WriteLine("Qual Operação deseja utilizar?");
        System.Console.WriteLine("SOMA - 1  SUBTRAÇÃO - 2    MULTIPLICAÇÃO - 3    DIVISÃO - 4   MÉDIA - 5");
        one.operacao = int.Parse( Console.ReadLine() );
        System.Console.WriteLine("Digite o Primeiro Valor: ");
        one.n1 = int.Parse( Console.ReadLine() );
        System.Console.WriteLine("Digite o Segundo Valor: ");
        one.n2 = int.Parse( Console.ReadLine() );
        switch(one.operacao){
        case 1:
        Console.WriteLine(one.Soma());
        break;
        case 2:
        Console.WriteLine(one.Subtracao());
        break;
        case 3:
        Console.WriteLine(one.Multiplicacao());
        break;
        case 4:
        Console.WriteLine(one.Divisao());
        break;
        case 5:
        Console.WriteLine(one.MediaF());
        break;
        default:
        Console.WriteLine("Caractere Invalido");
        break;
        }
     
        }
    
    }
}
