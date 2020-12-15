namespace AulaPOOCelular
{
    public class Celular
    {
        public bool ligado;
        public string cor;
        public string modelo;
        public int tamanho;
        public string VerCor(){
            return cor;
        }
        public int VerTamanho(){
            return tamanho;
        }
        public string VerModelo(){
            return modelo;
        } 

/// <summary>
/// Aprimora a resposta do usuário
/// </summary>
/// <param name="situacao"></param>
/// <returns>retorna se o celular está ou não ligado</returns>
        public bool TraduzConsole(string situacao){
            if (situacao == "sim"||situacao == "true"){
                ligado = true;
            }
            else {
                ligado =false;

            }
            return ligado;
        }
    
    }
}