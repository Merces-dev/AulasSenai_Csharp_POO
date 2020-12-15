using System;
namespace Aula13Uber
{
   	 public class Usuario
    	{
        //Propriedade resumida
        public string Nome { get; set; }

        //Propriedade completa
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { 
                if (idade > 0){
                    idade = value;
                }
            }
        }
        public string Foto { get; set; }
        private string login = "tejota@gmail.com";
        private string senha = "123";
        public string localizacaoAtual { get; set; }    
        public string tokenLogin { get; set; }  
        public bool Login(string login, string senha){
            if(this.login == login && this.senha == senha ){
                tokenLogin = "ffn890hfnw8gf8dgf7sf7dfsd7f649whfpsduf";
                return true;
    }
                return false;
            }
            public void Logout(){ 
                tokenLogin = "ndsffnio0wf2783ftg327783f78wfdgsdgf8s";
           
            } 
}
}
    
