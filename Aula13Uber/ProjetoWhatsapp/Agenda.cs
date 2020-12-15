using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjetoWhatsapp
{
    public class Agenda : IAgenda
    {
        public List<Contato> Contatos;
        public const string PATH = "Database/produto.csv";
        public Agenda()
        {
        }
        public Agenda(List<Contato> _contatos){
            this.Contatos = _contatos;
        }
        private string PrepararLinha(Contato c)
        {
            return $"Contato = {c.Nome};Telefone = {c.Telefone}";
        }

        public void Cadastrar(Contato _cont)
        {
        var linha = new string[] { PrepararLinha(_cont) };
        File.AppendAllLines(PATH, linha);
        }

        public void Excluir(string _termo)
        {
        List<string> linhas = new List<string>();
        using (StreamReader arquivo = new StreamReader(PATH)){
            string linha;
            while ((linha = arquivo.ReadLine())!= null){
                linhas.Add(linha);
            }
        }
        {
            linhas.RemoveAll(l => l.Contains(_termo));
            {
            using (StreamWriter output = new StreamWriter(PATH))
            {
                foreach (string ln in linhas)
                {
                    output.Write(ln + "\n");
                }
            }
        }
        }
        }

        public List<Contato> Listar()
        {
        List<Contato> contatos = new List<Contato>();
        string[] linhas = File.ReadAllLines(PATH);
        foreach (string line in linhas)
        {
            string[] dados = line.Split(";");
            Contato c = new Contato();
            c.Nome = dados[0];
            c.Telefone = dados[1];
            contatos.Add(c);
        }
        contatos = contatos.OrderBy(x => x.Nome).ToList();
        return contatos;
        }

    }
}