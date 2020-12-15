namespace Aula06Heranca
{
    public class Pessoa
    {
         public string nome;
         /// <summary>
         /// Envia um texto ao usuário
         /// </summary>
         /// <returns>retorna um texto de saudação ao usuário</returns>
         public string Saudacao(){
            return "Olá, Seja Bem-vindo(a), " + nome; 
         }
         /// <summary>
         /// Envia um texto ao usuário
         /// </summary>
         /// <returns>retorna um texto de saudação ao usuario da loja</returns>
              public string SaudacaoLoja(){
            return "Olá, Seja Bem-vindo(a) a loja, " + nome; 
         }
    }
}