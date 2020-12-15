using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
         DateTime localDate = DateTime.Now;
         Motorista junin = new Motorista();
         Passageiro tejota = new Passageiro();
         tejota.Nome = "Tejota";
         junin.Nome = "Junin";
         System.Console.WriteLine("Digite seu Login");
         string login = Console.ReadLine();
         System.Console.WriteLine("Digite sua Senha");
         string senha = Console.ReadLine();
         Console.Clear();


        tejota.Login(login, senha);

        if( tejota.tokenLogin != "" && tejota.tokenLogin != null ){
                
            System.Console.WriteLine("Login autorizado!");
            //System.Console.WriteLine(tejota.TokenLogin);
            System.Console.WriteLine("Olá, "+tejota.Nome+", Deseja solicitar uma viagem? ");
            bool situacaoViagem = bool.Parse(Console.ReadLine());
            if(situacaoViagem == true){
            tejota.SolicitarMotorista();
            System.Console.WriteLine("Qual o destino da corrida?");
            string localChegada = Console.ReadLine();
            System.Threading.Thread.Sleep(700);
            System.Console.Clear();
            // string situacaoCartao = Console.ReadLine();
            // tejota.CadastrarCartao();
            // System.Threading.Thread.Sleep(700);
            // System.Console.Clear();
            System.Console.WriteLine("Passageiro: "+tejota.Nome);
            System.Console.WriteLine("Motorista: "+junin.Nome);
            System.Console.WriteLine("Destino: "+localChegada);
            System.Console.WriteLine("Data: "+localDate);


            System.Threading.Thread.Sleep(1300);
            System.Console.Clear();
            tejota.Pagar("finalizada");
            if(tejota.Pagar("finalizada") == true){
            System.Console.WriteLine("Corrida em andamento...");
            System.Threading.Thread.Sleep(700);
            System.Console.Clear();
            System.Console.WriteLine(tejota.Nome+" chegou ao destino final e o pagamento será cobrado automaticamente de seu cartão de crédito");

            }


        
            }
        }
        else{
                System.Console.WriteLine("Não é possível utilizar o app");
            }
        }
    }
}
