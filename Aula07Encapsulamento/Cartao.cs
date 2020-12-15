using System;
namespace Aula07Encapsulamento
{
    public class Cartao
    {
          public string numero { get; set; }

        public string titular { get; set; }

        public string bandeira { get; set; }

        private string token = "42asadasr432532das43ds";

        protected string cvv { get ; set; }


        public void AprovarCompra(){
            Console.WriteLine("Sua Compra Foi Aprovada!");
        }

        private bool ValidarToken(){
            return true;
        }

        protected bool ValidarCompra(){
            return true;
        }

    }
}