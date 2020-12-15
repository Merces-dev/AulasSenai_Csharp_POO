using System;

namespace PrimeiroPoo
{
    class Program
    {
        static void Main(string[] args)
        {
             Personagem riri = new Personagem();
            riri.nome = "Riri Williams";    
            riri.armadura = "Iron Heart";
            riri.vida = 100;
            riri.idade = 15;
            Console.WriteLine("Nome: "+riri.nome);
            Console.WriteLine("Idade: "+riri.idade+" anos");
            Console.WriteLine("Armadura: "+riri.armadura);
            Console.WriteLine("O(a) "+riri.nome+" tem "+riri.vida+" pontos de vida");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();
      
            // Console.WriteLine(riri.Defender());
            // Console.WriteLine(riri.Atacar(34.5f, 20f));

            Personagem spiderman = new Personagem();
            spiderman.nome = "Spider Man";
            spiderman.idade = 25;
            spiderman.vida = 89;
            spiderman.armadura = "Uniforme";    
            Console.WriteLine("Nome: "+spiderman.nome);
            Console.WriteLine("Idade: "+spiderman.idade+" anos");
            Console.WriteLine("Armadura: "+spiderman.armadura);
            Console.WriteLine("O(a) "+spiderman.nome+" tem "+spiderman.vida+" pontos de vida");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("O(a) "+riri.nome+riri.AtacarString()+spiderman.nome+" com "+riri.Atacar(20f,5f)+" de Dano");

        }
    }
}
