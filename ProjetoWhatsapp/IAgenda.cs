using System.Collections.Generic;

namespace ProjetoWhatsapp
{
    public interface IAgenda
    {
    List<Contato> Listar();
    void Cadastrar(Contato cont);
    void Excluir(Contato cont);


    }
}