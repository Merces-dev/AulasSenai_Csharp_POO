namespace Aula22Static
{
    public class Conversor
    {
        public static float CotacaoDolar = 5.23f;
        public static float CotacaoEuro = 5.90f;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna o valor de Real Para Dolar</returns>
        public static float ConverterRealParaDolar(float valor){
            return valor / CotacaoDolar;
        }     
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna o Valor de Dolar para Real</returns>
        public static float ConverterDolarParaReal(float valor){
            return valor * CotacaoDolar;
        }   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna o valor de Real para Euro</returns>
        public static float ConverterRealParaEuro(float valor){
            return valor / CotacaoEuro;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>Retorna o valor de Euro para Real</returns>
        public static float ConverterEuroParaReal(float valor){
            return valor * CotacaoEuro;
        }
    }
}