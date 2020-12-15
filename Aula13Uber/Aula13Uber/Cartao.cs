using System;
namespace Aula13Uber
{
    public class Cartao: Passageiro
    {
    private string numero{get; set;}
    private string titular { get; set; } 
    private string bandeira { get; set; }    
    private string cvv { get; set; }
    private string situacaoCartao{get; set;} 
    public void CadastrarCartao(){
        System.Console.WriteLine("Deseja cadastrar seu cartão?");
        string situacaoCartao = Console.ReadLine();
    if(situacaoCartao == "sim"){
        System.Console.WriteLine("Digite o número do cartão: ");
        string numero = Console.ReadLine();

        System.Console.WriteLine("Digite o nome do titular: ");
        string titular = Console.ReadLine();

        System.Console.WriteLine("Digite a bandeira do cartão: ");
        string bandeira = Console.ReadLine();
        
        System.Console.WriteLine("Digite o código de segurança do cartão: ");
        string cvv = Console.ReadLine();
    }
    else{
        System.Console.WriteLine("Impossível iniciar corrida");
    }
    }
    public void excluirCartao(string agencia, string conta){
        if(situacaoCartao == "excluir"){
        System.Console.WriteLine("Seu cartão será excluído...");            
            
            
        }

        }
    }
}
