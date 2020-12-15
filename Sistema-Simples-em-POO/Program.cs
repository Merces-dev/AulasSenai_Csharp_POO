using System;

namespace SistemaSimplesPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno giovani = new Aluno();
            giovani.nome = "Giovani";
            giovani.idade =17;

            giovani.valorMensalidade = 3000;
            giovani.mediaFinal = 9.3f;
            giovani.percentual = 70;
            Console.WriteLine("Aluno Bolsista?");
            giovani.bolsista = giovani.TraduzConsole( Console.ReadLine() );
            Console.WriteLine("Média final de "+giovani.nome+" : "+giovani.VerMediaFinal());
            Console.WriteLine("Mensalidade de "+giovani.nome+" : R$"+giovani.VerMensalidade());



        }
    }
}
