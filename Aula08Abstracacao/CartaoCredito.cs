namespace Aula08Abstracacao
{
    public class CartaoCredito : Cartao
    {
    public float limite { get; set; }
    public  void AumentarLimite(float acrescimo){
        limite = limite + acrescimo;
        
        token = "r69rfv6tszxerawqeERQEQW";
    }
    }
}