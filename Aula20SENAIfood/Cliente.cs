namespace SENAIfood
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public string EnderecoAtual { get; set; }
        public Cliente(string _nome,string _enderecoAtual){
            this.NomeCliente = _nome;
            this.EnderecoAtual = _enderecoAtual;



        }
        public string MostrarDados() { 
            return $"Nome do Cliente: {NomeCliente}\nEndereço do Cliente: {EnderecoAtual}";
        }   
    }
}