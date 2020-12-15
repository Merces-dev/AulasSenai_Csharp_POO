namespace ProjetoWhatsapp
{
    public class Contato
    {
      public string Nome { get; set; }  
      public string Telefone { get; set; }
      public Contato(){
        
          
      }
      /// <summary>
      /// Método Construtor 
      /// </summary>
      /// <param name="_nome"></param>
      /// <param name="_telefone"></param>
      public Contato( string _nome, string _telefone){
          this.Nome = _nome;
          this.Telefone = _telefone;
      }
    }
}