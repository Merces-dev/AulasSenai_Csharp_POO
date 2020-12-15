namespace SENAIfood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereco{ get; set; }
        public string Itens{get; set;}
        public  Restaurante(string _nome, string _endereco){
            this.NomeFantasia = _nome;
            this.Endereco = _endereco;

        }
        public string MostrarDados() { 
            return $"Nome do Restaurante: {NomeFantasia}\nEndereço do Restaurante: {Endereco}";
        }
    }
}