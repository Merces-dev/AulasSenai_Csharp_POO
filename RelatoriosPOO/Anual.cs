using System;
namespace RelatoriosPOO
{
    public class Anual : Relatorio
    {
    public override void MostrarRelatorio(){
    base.MostrarRelatorio();
    System.Console.WriteLine("Mostrando Relatório Anual: "+dataGeral);
    }
    }
}