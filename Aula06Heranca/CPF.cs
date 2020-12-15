namespace Aula06Heranca
{
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidarCpf(){
            if(cpf != null){
                return true;
            }
            return false;   
        }
    }
}