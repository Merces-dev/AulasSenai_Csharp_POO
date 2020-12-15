using System;

namespace Aula08Abstracacao
{
    class Program
    {
        static void Main(string[] args)
        {
        CartaoCredito visa = new CartaoCredito();        
        visa.limite = 2000f;

        System.Console.WriteLine("Quanto de acréscimo?");
        float acrescimo = float.Parse(Console.ReadLine());
        visa.AumentarLimite(acrescimo);
        System.Console.WriteLine("Novo Limite: R$"+visa.limite);
        System.Console.WriteLine("Digite a data do pagamento:");
        visa.data = DateTime.Parse(Console.ReadLine());
        System.Console.WriteLine("Data: "+visa.data);
    }
}
}