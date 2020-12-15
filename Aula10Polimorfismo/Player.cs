using System;
namespace Aula10Polimorfismo
{
    public class Player
    {
        // virtual dá a possibilidade de transcrever o método - classe Pai
        public virtual void Pular(){
            System.Console.WriteLine("O Personagem está pulando normalmente");
        }
        public virtual void Correr(){
            System.Console.WriteLine("O Personagem está correndo normalmente");
        }
    }
}