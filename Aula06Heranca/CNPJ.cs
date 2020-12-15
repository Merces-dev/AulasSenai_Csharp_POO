namespace Aula06Heranca
{
    public class CNPJ : Pessoa
    {
        public string cnpj;

        public bool ValidarCNPJ(){
            if(cnpj != null){
                return true;
            }
            return false;
        }
        
    }
}