namespace Aula08Abstracacao
{
    public class Cartao : Pagamento
    {
        protected string token = "sdopqhnd3indoa4bo033bndw008da3b832r23";
        public string titular { get; set; }
        public string cvv { get; set; }
        public string bandeira { get; set; }
        public bool ValidarToken(){
            if(token!= null){
                return true;
            }
            return false;
        }
    }
}