using System;
namespace Aula07Encapsulamento
{
    public class Mastercard : Cartao
    {
        public int parcelas {get; set;}
        public void CompraComDescontoMastercard(float desconto){
            Console.WriteLine($"Compra realizada com {parcelas} parcelas e {desconto}% de desconto");
        }
    }
}