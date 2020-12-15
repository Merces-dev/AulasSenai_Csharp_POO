using System;
namespace Aula08Abstracacao
{
    public class Boleto : Pagamento

    {

    public DateTime dataVencimento { get; set; }    
    
    public string bancoEmissor { get; set; }
    public string codDeBarras { get; set; }
    public string Registrar(){
        return "Boleto aceito com sucesso";
    }
    }
}