  
using System;

namespace Aula19Dojo
{
    class Program
    {
        
        static void Main(string[] args)
        {

            IngressoVip bilhete = new IngressoVip();

            System.Console.Write("Digite qual show deseja ir: ");
            System.Console.WriteLine("1 - Henrique e Juliano / 2 - Jorge e Mateus / 3 - Chitãozinho e Xororó");
            int show = int.Parse(Console.ReadLine());
            switch (show)
            {
                case 1:
                bilhete.IngressoPreco = 55f;
                break;

                case 2:
                bilhete.IngressoPreco = 25f;
                break;

                case 3:
                bilhete.IngressoPreco = 58f;
                break;

                default:
                Console.WriteLine( "Dígito Inválido" );
                break;
            }
            System.Console.WriteLine("Deseja um Ingresso vip?: (True ou False) ");
            bool situacaoVip = Boolean.Parse(Console.ReadLine());
            if (situacaoVip == true){
                bilhete.valorAdicional = bilhete.IngressoPreco * 0.2f;
            }
            else{
                bilhete.valorAdicional = 0f;
            }

            Console.Clear();
            bilhete.ImprimirValor();
            bilhete.AdicionarValor();

            
        }
    }
}