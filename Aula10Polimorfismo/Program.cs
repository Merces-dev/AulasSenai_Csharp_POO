using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
        System.Console.WriteLine("Mario: ");
        Mario mario = new Mario();
        mario.Correr();
        mario.Pular();
        System.Console.WriteLine("Mario: ");
        Luigi luigi = new Luigi();
        luigi.Correr();
        luigi.Pular();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
