using System;
using System.Collections.Generic;

namespace ProjetoWhatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato c1 = new Contato("Giovani Merces","11 99999-9999");
            Agenda c = new Agenda();
            Mensagem m = new Mensagem("Testando...", "Juninho");
            c.Cadastrar(c1);
            c.Excluir("Zezinho");
            m.Enviar(c1);
            // List<Contato> lista = c1.Listar();
            // foreach (Contato item in lista)
            // {
            //     System.Console.WriteLine($"Nome{item.Nome} - Telefone{item.Telefone}");
            // }


        }
    }
}
