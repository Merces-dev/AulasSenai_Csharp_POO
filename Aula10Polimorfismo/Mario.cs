namespace Aula10Polimorfismo
{
    public class Mario : Player
    {
        // override(modificador) transcreve o método - classe Filha
        public override void Correr(){
            System.Console.WriteLine("O Mário está correndo mais rápido agora!");
        }
    }
}