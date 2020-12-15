using System.Collections.Generic;

namespace Aula27_28_29_30
{
    public interface IProduto
    {
        void Cadastrar();
        List<Produto> Ler();
        string PrepararLinha();
        List<Produto> Filtrar();
        string SepararDados();
        void ReescreverCSV();
        void Remover();
        void Alterar();
    }
}