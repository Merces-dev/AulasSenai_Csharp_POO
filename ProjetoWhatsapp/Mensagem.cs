using System;
using System.Collections.Generic;
using System.IO;

namespace ProjetoWhatsapp
{
    public class Mensagem : Agenda
    {
        public string Texto { get; set; }
        public string Destinatario { get; set; }
        public Mensagem(){

        }
        public Mensagem(string _texto, string _destinatario){
            this.Texto = _texto;
            this.Destinatario = _destinatario;
        }
        
        /// <summary>
        /// Envia a Mensagem
        /// </summary>
        public void Enviar(){
        
        List<string> linhas = new List<string>();
        using(StreamReader leitor = new StreamReader(PATH)){

        string linha;

        while((linha = leitor.ReadLine()) != null){
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine($"Nome: {linha.Split(";")[0].Split("=")[1]} / Telefone: {linha.Split(";")[1].Split("=")[1]}");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.WriteLine($"Mensagem: {Texto} Para: {Destinatario}" );
        System.Console.WriteLine();
        }
    }
}
}
}