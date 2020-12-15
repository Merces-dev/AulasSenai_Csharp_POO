using System;
namespace RelatoriosPOO
{
    public class Relatorio 
    {
    public DateTime dataGeral {get; set;}
    public virtual void MostrarRelatorio(){
        System.Console.WriteLine("Mostrando Relatório Geral: "+dataGeral);
    }
    }
}