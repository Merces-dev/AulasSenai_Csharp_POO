namespace SistemaSimplesPOO
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public string rg;
        public bool bolsista; //true or false = bool
        public float percentual; 
        public float mediaFinal;
        public float valorMensalidade;
        /// <summary>
        /// Mostra a Média Final do Aluno
        /// </summary>
        /// <returns>Média Final (float)</returns>
        public float VerMediaFinal(){
        

        return mediaFinal;
        }  
        /// <summary>
        /// Calcula a Mensalidade de acorda com o bolsa disponível(ou não)
        /// </summary>
        /// <returns>Valor da mensalidade a ser paga</returns>
        public float VerMensalidade(){
            
            float calculo = valorMensalidade;
           if(bolsista == true){
               calculo = valorMensalidade - (valorMensalidade * percentual/100);
           }
            return calculo; 
        }
        /// <summary>
        /// Aprimora a resposta do usuário
        /// </summary>
        /// <param name="condicao">texto capturado pelo console</param>
        /// <returns>retorna se é bolsista ou não</returns>
        public bool TraduzConsole(string condicao){
            if (condicao == "sim"){
                bolsista = true;
            }else{
                bolsista = false;
            }
            return bolsista;
        }
    }
}