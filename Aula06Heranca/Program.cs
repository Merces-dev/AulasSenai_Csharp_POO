using System;

namespace Aula06Heranca
{
    class Program
    {
        static void Main(string[] args)
            {
            
            CPF cpf = new CPF();
            cpf.nome = "Giovani";
            Console.WriteLine( cpf.Saudacao() );

           Console.WriteLine("Digite seu CPF para validação:");
            Console.WriteLine();
            cpf.cpf= Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine( cpf.ValidarCpf () );


            // CNPJ cnpj = new CNPJ();
            // cnpj.nome = "GRMT Store";
            // Console.WriteLine( cnpj.SaudacaoLoja() );

            // cnpj.cnpj = "229.554.565/5656.54";
            // Console.WriteLine( cnpj.ValidarCNPJ() );

            
    
        }
    }
}