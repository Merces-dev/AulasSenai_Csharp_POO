using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
        Celular iphone = new Celular();
        iphone.modelo = "Iphone 6";
        iphone.cor = "Prata";
        iphone.tamanho = 5;
    


        
        Console.WriteLine("Deseja ligar o celular?");
        iphone.ligado = iphone.TraduzConsole(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        
       
        Console.WriteLine("Modelo : "+iphone.VerModelo());
        Console.WriteLine("Cor : "+iphone.VerCor());
        Console.WriteLine("Tamanho : "+iphone.VerTamanho());
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        if (iphone.ligado == true){
        Console.WriteLine("O que deseja fazer com o celular?");
        Console.WriteLine("Desligar, Ligação ou Mensagem (Digitar da forma que está escrito)");
        Console.WriteLine();
        string acao = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        if (acao == "Desligar" || acao == "desligar" || acao == "DESLIGAR"){
        Console.WriteLine("Você Desligou o celular");
        }
        if (acao == "Mensagem" || acao == "mensagem" || acao == "MENSAGEM"){
        Console.WriteLine("Você Enviou uma Mensagem");
        }
         if (acao == "LIGACAO" || acao == "ligacao" || acao == "Ligação"|| acao == "LIGAÇÃO"|| acao == "ligação"){
        Console.WriteLine("Você Fez uma ligação");
        }
        else{
        Console.WriteLine("Comando errado, parceirão");
        }

        }
    
        if(iphone.ligado == false){
        Console.WriteLine("O celular está Desligado");
   }
  }
 }
}
