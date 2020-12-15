using System;
namespace Aula13Uber
{
    public class Conta: Motorista
    {
        private string agencia { get; set; }
        private string conta { get; set; }
        public string situacaoConta{get; set;}

        public void CadastrarConta(){ 
        if(situacaoConta == "cadastrar"){
            System.Console.WriteLine("Digite sua Agência: ");
            string agencia = Console.ReadLine();
            System.Console.WriteLine("Digite sua Conta: ");
            string conta = Console.ReadLine();
        }

        }
        public void ExcluirConta(string agencia, string conta){
            if(situacaoConta == "excluir"){
            System.Console.WriteLine("Sua conta será excluida...");            
        }
        }
    }
}