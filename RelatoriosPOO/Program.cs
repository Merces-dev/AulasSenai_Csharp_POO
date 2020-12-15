using System;

namespace RelatoriosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio geral = new Relatorio();
            geral.MostrarRelatorio();  
            Anual anual = new Anual();
            anual.MostrarRelatorio();  
            Mensal mensal = new Mensal();
            mensal.MostrarRelatorio();  


        }

    }
}
