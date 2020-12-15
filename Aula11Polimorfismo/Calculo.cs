namespace Aula11Polimorfismo
{
    public class Calculo
    {
      
        public string CalcularVida(){
            return "Não houve nenhum calculo a ser aplicado";       
        }
        public string CalcularVida(int vida){
            return "A vida do jogador está com "+vida;
        }
        public string CalcularVida(int vida, int escudo){
            return "A vida do jogador com escudo é "+(vida+escudo);
        }
        public string CalcularVida(string nome, string sobrenome){
            return $"O nome completo do jogador é {nome} {sobrenome}";
        }
        public string CalcularVida(int vida, int escudo, int dano, string nome){
        return $"O Player {nome} sofreu um dano de {dano}, porem ele havia utilizado sua ULT que devolvia o dano sofrido multiplicado por sua vida no seu oponente, seu oponente sofreu as consequências e recebeu {(vida*dano)} de dano";
        }
        public string CalcularVida(int vida, int escudo,int dano){
            return $"A vida do jogador estava em {vida + escudo} com a presença do escudo, porem tomou um golpe de {dano} e ficou com {(vida+escudo-dano)} de vida total";
        }
    }

}