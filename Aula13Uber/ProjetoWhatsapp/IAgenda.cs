using System.Collections.Generic;

namespace ProjetoWhatsapp
{
    public interface IAgenda
    {
    List<Contato> Listar();
    void Cadastrar(Contato _cont);
    void Excluir(string _termo);


    }
}