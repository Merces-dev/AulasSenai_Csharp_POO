using System;

namespace ProjetoWhatsapp
{
    public class Mensagem : Contato
    {
        public string Texto { get; set; }
        public string Destinatario { get; set; }
        public Mensagem(){

        }
        public Mensagem(string _texto, string _destinatario){
            this.Texto = _texto;
            this.Destinatario = _destinatario;
        }
        public void Enviar(Contato c){
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine($"Contato : {c.Nome} - Telefone{c.Telefone} - Enviou");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine($"Mensagem: {Texto} Para: {Destinatario}");
        }
    }
}