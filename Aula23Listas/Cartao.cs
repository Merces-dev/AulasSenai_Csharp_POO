namespace Aula23Listas
{
    public class Cartao
    {
        public string Titular { get; set; }
        public string Bandeira { get; set; }
        public string Vencimento { get; set; }
        public int Cvv { get; set; }
        public int NumeroCartao { get; set; }
        public Cartao() { 

        }
        public Cartao(string _titular, string _bandeira, string _vencimento, int _cvv, int _numeroCartao){ 
        this.Titular = _titular;
        this.Bandeira = _bandeira;
        this.Vencimento = _vencimento;
        this.Cvv = _cvv;
        this.NumeroCartao = _numeroCartao;

        }
    }
}