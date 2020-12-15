namespace Aula10Polimorfismo
{
    public class Luigi : Mario
    {
         // override(modificador) transcreve o método - classe Filha
        public override void Pular(){
            //Aproveitando ações da base
            base.Pular();   
            //Adicionando novas ações
            System.Console.WriteLine("O Luigi também pode pular 30% mais alto");
        }
    }
}