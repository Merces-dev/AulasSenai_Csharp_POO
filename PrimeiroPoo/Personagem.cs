namespace PrimeiroPoo
{
    public class Personagem
    {
        
        public string nome;
        public int idade;
        public int vida;
        public string armadura;
        public float Atacar(float forca , float potencia)
        {
        return forca * potencia;
        }

        public string AtacarString()
    {
        return " atacou ";
    }
    }
}