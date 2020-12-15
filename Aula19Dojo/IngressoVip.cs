using System;

namespace Aula19Dojo
{ 
    public class IngressoVip : Ingresso
    {
        public float valorAdicional {get; set;}


        public void AdicionarValor(){
            float newValor = IngressoPreco + valorAdicional;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("O valor a mais do VIP é : {0:c}",valorAdicional);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O valor total é : {0:c}",newValor);
            Console.ResetColor();

        }

    }
}